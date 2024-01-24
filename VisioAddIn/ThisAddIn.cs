using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace VisioAddIn
{
    public partial class ThisAddIn
    {
        public class Config
        {
            public string Name { get; set; }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {
                var config = new Config() { Name = "abc" };
                var jsonString = JsonSerializer.Serialize(config);
                MessageBox.Show(jsonString);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
