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
                PointsDataGrid.Rows.Add(item.Result.PayPointId, item.Result.PostIndex, "", "");
            }
        }

        private async void CreateCertRequest()
        {
            var lastKeyFile = "";
            foreach (var item in PointsDataGrid.Rows)
            {
                var row = (DataGridViewRow)item;
                var point = row.Cells["Point"].Value;
                Log($"* пункт {point} * выбран.");
                var basePath = $@"d:\!!!Валидата!!!\Справочники\{point}";
                if (System.IO.File.Exists(basePath + @"\local.gdbm"))
                {
                    Log($"* пункт {point} * файлы справочника сертификатов доступны.");
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
                    if (lastKeyFile != file.Name)
                    {
                        file.CopyTo(Path.Combine(basePath, file.Name));
                        Log($"* пункт {point} * закрытый ключ {file.Name} скопирован.");
                        row.Cells["KeyFile"].Value = file.Name;
                    }
                    else
                    {
                        Log($"* пункт {point} * закрытый ключ НЕ найден.");
                    }

                    SendKeys.SendWait("%{F4}");
                    SendKeys.SendWait("{ENTER}");
                    await Task.Delay(3000);
                }
                else
                {
                    Log($"* пункт {point} * файлы справочника сертификатов НЕДОСТУПНЫ.");
                    Log($"* пункт {point} * запрос на сертификат НЕ создан.");
                }
            }
        }
        private void Log(string message)
        {
            var result = DateTime.Now + " " + message;

            ResultText.AppendText($"{result}\n");
            Debug.WriteLine(message);
        }
    }
}
