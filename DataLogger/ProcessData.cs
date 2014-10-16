using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger
{
    class ProcessData
    {
        private System.IO.Ports.SerialPort serialPort;

        private String _collectedData;

        public String collectedData
        {
            get
            {
                return _collectedData;
            }
            set
            {
                TimeSpan time = DateTime.Now.TimeOfDay;

                _collectedData = String.Format("{0};{1}\r\n", time.ToString("hh\\:mm\\:ss"), value);
            }
        }

        private static ProcessData process;

        private ProcessData()
        {
        }

        public static ProcessData SetupProcessing(System.IO.Ports.SerialPort serialPort)
        {
            if (process == null)
            {
                process = new ProcessData();
            }

            process.setPort(serialPort);

            return process;
        }

        public void setPort(System.IO.Ports.SerialPort serialPort)
        {
            if (this.serialPort != null)
            {
                try
                {
                    this.serialPort.Close();
                }
                catch (System.IO.IOException)
                {
                    throw new InvalidOperationException(
                        "Não foi possível fechar a porta. Você desconectou antes de parar a medição?"
                    );
                }
            }

            this.serialPort = serialPort;
            this.serialPort.Open();
        }

        public void read()
        {
            String errorMessage = null;

            try
            {
                errorMessage = null;
                this.collectedData = this.StringToCSV(this.serialPort.ReadLine());
            }
            catch (System.InvalidOperationException exception)
            {
                errorMessage = "Ocorreu um erro durante a leitura da porta serial. A mensagem de erro foi: " + exception.Message;
            }
            catch (System.IO.IOException exception)
            {
                errorMessage = "Ocorreu um erro de IO. Você abriu o arquivo CSV antes de encerrar a leitura? Mensagem: " + exception.Message;
            }
            finally
            {
                if (errorMessage != null && errorMessage.Length > 0)
                {
                    throw new InvalidOperationException(errorMessage);
                }
            }
        }

        private string StringToCSV(string data, char delimiter = ' ')
        {
            return data.Trim().Replace(delimiter, ';');
        }

        public String getCollectedData()
        {
            return this.collectedData;
        }
    }
}
