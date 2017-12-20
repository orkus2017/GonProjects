using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;
using System.IO;

namespace CambiadorLineaExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Office.Interop.Excel.Application _app = new Microsoft.Office.Interop.Excel.Application();
            _app.Visible = false;
            _app.DisplayAlerts = false;
            List<string> registro = new List<string>();

            string[] archivos = System.IO.Directory.GetFiles(@"\\serv-6\PresupuestosExcel\PtosExcelSnake", "*.xls");
            int cont = 0;
            DateTime _fechaini = DateTime.Now.AddYears(-2);

            StreamReader sr = new StreamReader(@"D:\Trabajos\2017-12-19 Presupuestos excel\registro.txt");
            while (!sr.EndOfStream)
            {
                registro.Add(sr.ReadLine());
            }
            sr.Close();

            //sw.

            archivos = archivos.OrderByDescending(z => z).ToArray();

            foreach (string archivo in archivos)
            {
                try
                {
                    cont++;

                    if (!archivo.Contains("TMP_") || archivo.Contains("~"))
                    {
                        Console.WriteLine("Archivo ya hecho: " + archivo);
                        continue;
                    }

                    //if (archivo.Contains("jcromero"))
                    //{
                    //    Console.WriteLine("Archivo otro: " + archivo);
                    //    continue;
                    //}

                    if (registro.Contains(archivo))
                    {
                        Console.WriteLine("Ya esta actualizado: " + archivo);
                        continue;
                    }

                    //System.IO.FileInfo _fileinfo = new System.IO.FileInfo(archivo);

                    //if (_fileinfo.LastWriteTime <= _fechaini) continue;

                    Console.WriteLine("Abriendo archivo (" + cont.ToString() + " de " + archivos.Length + "): " + archivo);
                    Workbook _wb = _app.Workbooks.Open(archivo, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    ///////////////////////////////////////////////////////////////////////////////////////////
                    //  Movidas varias para cambiar el código vba del excel a machete

                    Console.WriteLine("   ->Cambiando línea");

                    VBComponent component = null;
                    CodeModule module = null;

                    component = _wb.VBProject.VBComponents.Item("Hoja2");
                    module = component.CodeModule;
                    int linea = 24;

                    string a = module.Lines[linea, 1];

                    if (a == "")
                    {
                        component = _wb.VBProject.VBComponents.Item("Hoja3");
                        module = component.CodeModule;
                        linea = 28;
                        a = module.Lines[linea, 1];
                    }

                    Console.WriteLine("   ->Lines[" + linea.ToString() + ", 1]: '" + module.Lines[linea, 1] + "'");

                    if (a.Contains(@"\\sc.es\WebsIO\Temp\PtosExcelSnake\"))
                    {
                        a = a.Replace(@"\\sc.es\WebsIO\Temp\PtosExcelSnake\", @"\\serv-6\PresupuestosExcel\PtosExcelSnake\");

                        module.ReplaceLine(linea, a);

                        Console.WriteLine("   ->Lines[" + linea.ToString() + ", 1]: '" + module.Lines[linea, 1] + "'");

                        Console.WriteLine("Guardando...");
                        _wb.Save();
                    }
                    else
                    {
                        Console.WriteLine("Ya esta actualizado");
                    }

                    ///////////////////////////////////////////////////////////////////////////////////////////
                    // Cierro el excel, limpiar todos los objetos

                    _wb.Close(null, null, null);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_wb);
                    _wb = null;

                    Console.WriteLine("Archivo OK: " + archivo);
                    Console.WriteLine();

                    registro.Add(archivo);
                    StreamWriter sw = File.AppendText(@"D:\Trabajos\2017-12-19 Presupuestos excel\registro.txt");
                    sw.WriteLine(archivo);
                    sw.Close();
                    sw.Dispose();
                    sw = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(" * ERROR:" + ex.Message + "\n" + ex.StackTrace);
                    Console.WriteLine();
                }
            }

            if (_app != null) _app.Workbooks.Close();
            if (_app != null) _app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_app);
            _app = null;

            GC.Collect();
        }
    }
}
