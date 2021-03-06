﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClientEditor
{
    public class Data<T> where T : AkEditor
    {
        public static List<CharColor> CharColorList { get; set; }
        public static List<ClassBase> ClassBaseList { get; set; }
        public static List<DyingItems> DyingItemsList { get; set; }
        public static List<Adventureroad> AdventureRoadList { get; set; }
        public static List<Pvp> PvpList { get; set; }
        public static List<Fight> FightList { get; set; }
        public static List<Mage> MageList { get; set; }
        public static List<PartnerGrow> PartnerGrowList { get; set; }
        public static List<PartnerTalk> PartnerTalkList { get; set; }
        public static List<Growequip> GrowEquipList { get; set; }
        public static List<Dialogue> DialogList { get; set; }
        public static List<T> LevelList { get; set; }

        public static void Flush(ListBox l, List<T> list)
        {
            list.Clear();
            l.Items.Clear();
            l.Items.Refresh();
        }

        public static void Remove(ListBox l)
        {
            
            try
            {
                int selected = l.SelectedIndex;
                Console.WriteLine(selected);
                switch (Settings.EditorID)
                {
                    case 1: Data<CharColor>.CharColorList.RemoveAt(selected);
                        break;
                    case 2: Data<ClassBase>.ClassBaseList.RemoveAt(selected);
                        break;
                    case 3: Data<DyingItems>.DyingItemsList.RemoveAt(selected);
                        break;
                    case 4: Data<Adventureroad>.AdventureRoadList.RemoveAt(selected);
                        break;
                    case 5: Data<Pvp>.PvpList.RemoveAt(selected);
                        break;
                    case 6: Data<Fight>.FightList.RemoveAt(selected);
                        break;
                    case 7: Data<Mage>.MageList.RemoveAt(selected);
                        break;
                    case 8: Data<PartnerGrow>.PartnerGrowList.RemoveAt(selected);
                        break;
                    case 9: Data<PartnerTalk>.PartnerTalkList.RemoveAt(selected);
                        break;
                    case 10: Data<Growequip>.GrowEquipList.RemoveAt(selected);
                        break;
                    case 11: Data<Dialogue>.DialogList.RemoveAt(selected);
                        break;
                    case 12: Data<Level>.LevelList.RemoveAt(selected);
                        break;
                }
                
                l.Items.RemoveAt(selected);
                l.SelectedIndex = 0;
                l.ScrollIntoView(l.Items.GetItemAt(0));
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("invalid Operation");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void Add(ListBox l)
        {
            try
            {
                l.Items.Add(l.Items.Count + 1);
                switch (Settings.EditorID)
                {
                    case 1:
                        Data<CharColor>.CharColorList.Add(new CharColor("0000", "", "0000", "0000", "0000"));
                        break;
                    case 2:
                        Data<ClassBase>.ClassBaseList.Add(new ClassBase("0000", "0.0", "0.0", "0.0", "0.0", "0.0", "0.0",""));
                        break;
                    case 3:
                        Data<DyingItems>.DyingItemsList.Add(new DyingItems("0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 4:
                        Data<Adventureroad>.AdventureRoadList.Add(new Adventureroad("0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000","0000","0000","0000","0000"));
                        break;
                    case 5:
                        Data<Pvp>.PvpList.Add(new Pvp("0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 6:
                        Data<Fight>.FightList.Add(new Fight("0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 7:
                        Data<Mage>.MageList.Add(new Mage("0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000"));
                        break;
                    case 8:
                        Data<PartnerGrow>.PartnerGrowList.Add(new PartnerGrow("0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 9:
                        Data<PartnerTalk>.PartnerTalkList.Add(new PartnerTalk("0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 10: Data<Growequip>.GrowEquipList.Add(new Growequip("0000", "0000", "0000", "0000", "0000", "0000", "0000", "000", "0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                    case 11: Data<Dialogue>.DialogList.Add(new Dialogue("0000", "0000"));
                        break;
                    case 12: Data<Level>.LevelList.Add(new Level("0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000", " 0000",
                                                               "0000", "0000", "0000", "0000", "0000",
                                                               "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000"));
                        break;
                }
                l.SelectedIndex = 0;
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Something went wrong.");
            }
            
        }

    }
}
