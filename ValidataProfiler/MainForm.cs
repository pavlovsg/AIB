using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCsvParser;
using WindowsInput;

namespace ValidataProfiler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPoints();
            CreateCertRequest();
        }

        private void LoadPoints()
        {
            var csvParserOptions = new CsvParserOptions(true, ';');
            var csvMapper = new PayPointMapping();
            var csvParser = new CsvParser<PayPoint>(csvParserOptions, csvMapper);
            var payPoints = csvParser
                        .ReadFromFile(@"data\points.csv", Encoding.ASCII)
                        .ToList();

            foreach (var item in payPoints)
            {
                PointsList.Items.Add(item.Result.PayPointId);
            }
            PointsList.SelectedIndex = 0;
        }

        private async void CreateCertRequest()
        {
            foreach (var item in PointsList.Items)
            {
                var point = item.ToString();
                Debug.WriteLine(DateTime.Now + " * пункт " + point + " * выбран.");
                var basePath = @"d:\!!!Валидата!!!\Справочники\" + point;
                if (System.IO.File.Exists(basePath + @"\local.gdbm"))
                {
                    var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Validata\zpki\Profiles\0\", true);

                    key.SetValue("BasePath", basePath);
                    key.Close();
                    key.Dispose();

                    var zcsExePath = @"c:\Program Files (x86)\Validata\zpki\zcs.exe";
                    System.Diagnostics.Process.Start(zcsExePath);
                    await Task.Delay(3000);

                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(2000);
                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(2000);
                    SendKeys.SendWait("^{F10}");
                    SendKeys.SendWait("{RIGHT}{DOWN}{DOWN}{DOWN}{ENTER}");
                    await Task.Delay(2000);
                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(2000);
                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(2000);
                    SendKeys.SendWait("{ENTER}");

                    var directory = new DirectoryInfo(@"E:\vdkeys\");
                    var file = directory.GetFiles()
                                 .OrderByDescending(f => f.LastWriteTime)
                                 .First();
                    file.CopyTo(Path.Combine(basePath, file.Name));

                    SendKeys.SendWait("%{F4}");
                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(3000);
                }
            }
        }
    }
}
