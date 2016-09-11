using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientEditor
{
    public class SaveFile
    {

        public static void Save(bool load)
        {
            if(load)
            {
                using (FileStream fs = new FileStream(Settings.File, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding(950)))
                    {
                        try
                        {
                            switch (Settings.EditorID)
                            {
                                case 1:
                                    writer.WriteLine(Settings.CharColorVersion);
                                    foreach (CharColor col in Data<CharColor>.CharColorList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|", col.ID, col.Color, col.Unknown02, col.Unknown03, col.Unknown04);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 2:
                                    writer.WriteLine(Settings.ClassBaseVersion);
                                    foreach (ClassBase cb in Data<ClassBase>.ClassBaseList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", cb.Unknown01, cb.Unknown02, cb.Unknown03, cb.Unknown04, cb.Unknown05, cb.Unknown06, cb.Unknown07, cb.Unknown08);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 3:
                                    writer.WriteLine(Settings.DyingItemsVersion);
                                    foreach(DyingItems d in Data<DyingItems>.DyingItemsList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|",
                                                                   d.Unknown01, d.Unknown02, d.Unknown03, d.Unknown04, d.Unknown05, d.Unknown06, d.Unknown07, d.Unknown08, d.Unknown09, d.Unknown10, d.Unknown11,
                                                                   d.Unknown12, d.Unknown13, d.Unknown14, d.Unknown15, d.Unknown16, d.Unknown17, d.Unknown18, d.Unknown19, d.Unknown20, d.Unknown21, d.Unknown22,
                                                                   d.Unknown23, d.Unknown24, d.Unknown25, d.Unknown26);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 4:
                                    writer.WriteLine(Settings.AdventureVersion);
                                    foreach(Adventureroad a in Data<Adventureroad>.AdventureRoadList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", 
                                            a.Unknown01, a.Unknown02, a.Unknown03, 
                                            a.Unknown04, a.Unknown05, a.Unknown06, 
                                            a.Unknown07, a.Unknown08, a.Unknown09, 
                                            a.Unknown10, a.Unknown11, a.Unknown12, a.Unknown13);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 5:
                                    writer.WriteLine(Settings.PvpVersion);
                                    foreach(Pvp p in Data<Pvp>.PvpList)
                                    {
                                        string s = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|",
                                                                p.Unknown1, p.Unknown2, p.Unknown3, p.Unknown4,
                                                                p.Unknown5, p.Unknown6, p.Unknown7, p.Unknown8,
                                                                p.Unknown9);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 6:
                                    writer.WriteLine(Settings.FightVersion);
                                    foreach(Fight f in Data<Fight>.FightList)
                                    {
                                        string s = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|",
                                                    f.Unknown01, f.Unknown02, f.Unknown03, f.Unknown04, f.Unknown05, f.Unknown06, f.Unknown07, f.Unknown08, f.Unknown09,
                                                    f.Unknown10, f.Unknown11, f.Unknown12, f.Unknown13, f.Unknown14, f.Unknown15, f.Unknown16, f.Unknown17, f.Unknown18, f.Unknown19,
                                                    f.Unknown20, f.Unknown21, f.Unknown22, f.Unknown23, f.Unknown24, f.Unknown25, f.Unknown26, f.Unknown27, f.Unknown28, f.Unknown29);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 7:
                                    writer.WriteLine(Settings.MageVersion);
                                    foreach(Mage m in Data<Mage>.MageList)
                                    {
                                        string s = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|",
                                                    m.Unknown01, m.Unknown02, m.Unknown03, m.Unknown04, m.Unknown05, m.Unknown06, m.Unknown07, m.Unknown08, m.Unknown09, m.Unknown10, m.Unknown11,
                                                    m.Unknown12, m.Unknown13, m.Unknown14, m.Unknown15, m.Unknown16, m.Unknown17, m.Unknown18, m.Unknown19, m.Unknown20, m.Unknown21, m.Unknown22);
                                        writer.WriteLine(s);
                                    }
                                    break;
                            }

                            MessageBox.Show("File Succesfully saved.");
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            
        }
    }
}
