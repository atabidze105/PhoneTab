using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace PhoneTab
{
    public partial class MainWindow : Window
    {
        private List<List<CheckBox>> _panels = new(); //список панелей 
        string _rndNumber = "0000000000";

        public MainWindow()
        {
            InitializeComponent();
            //---checkboxes---
            for (int i = 0; i < 10; i++)
            {
                List<CheckBox> boxes = new();
                StackPanel panel = new()
                {
                    Height = 95,
                    Width = 55,
                    Margin = new Avalonia.Thickness(10),
                    Background = Avalonia.Media.Brushes.Transparent
                };
                wrap.Children.Add(panel);

                Grid myGrid = new()
                {
                    ShowGridLines = false
                };
                panel.Children.Add(myGrid);

                for (int j = 0; j < 4; j++)
                {
                    myGrid.ColumnDefinitions.Add(new());
                }
                for (int l = 0; l < 7; l++)
                {
                    myGrid.RowDefinitions.Add(new());
                }

                for (int j = 0; j < 7; j++)
                {
                    for (int l = 0; l < 4; l++)
                    {
                        CheckBox checkBox = new();

                        checkBox.Click += CheckBox_Click;

                        boxes.Add(checkBox);
                        Viewbox box = new()
                        {
                            Width = 15,
                            Height = 15,
                            VerticalAlignment = VerticalAlignment.Center,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            Child = checkBox
                        };

                        box.SetValue(Grid.ColumnProperty, l);
                        box.SetValue(Grid.RowProperty, j);
                        myGrid.Children.Add(box);
                    }
                }
                _panels.Add(boxes);
            }
        }

        private void CheckBox_Click(object? sender, RoutedEventArgs e)
        {
            checkText.Text = number(checkText.Text);
        }

        private string number(string number)
        {
            string num2 = "";
            char[] num = number.ToCharArray();

            num[3] = numberBuild(_panels[0]);
            num[4] = numberBuild(_panels[1]);
            num[5] = numberBuild(_panels[2]);
            num[8] = numberBuild(_panels[3]);
            num[9] = numberBuild(_panels[4]);
            num[10] = numberBuild(_panels[5]);
            num[12] = numberBuild(_panels[6]);
            num[13] = numberBuild(_panels[7]);
            num[15] = numberBuild(_panels[8]);
            num[16] = numberBuild(_panels[9]);

            foreach (char c in num)
            {
                num2 += c;
            }
            return num2;
        }

        private char numberBuild(List<CheckBox> boxes)
        {
            if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                boxes[12].IsChecked == true && boxes[13].IsChecked == false && boxes[14].IsChecked == false && boxes[15].IsChecked == true &&
                boxes[16].IsChecked == true && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
            {
                return '0';
            }
            else
            {
                if (boxes[0].IsChecked == false && boxes[1].IsChecked == false && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                    boxes[4].IsChecked == false && boxes[5].IsChecked == true && boxes[6].IsChecked == true && boxes[7].IsChecked == false &&
                    boxes[8].IsChecked == false && boxes[9].IsChecked == false && boxes[10].IsChecked == true && boxes[11].IsChecked == false &&
                    boxes[12].IsChecked == false && boxes[13].IsChecked == false && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                    boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == true && boxes[19].IsChecked == false &&
                    boxes[20].IsChecked == false && boxes[21].IsChecked == false && boxes[22].IsChecked == true && boxes[23].IsChecked == false &&
                    boxes[24].IsChecked == false && boxes[25].IsChecked == false && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                {
                    return '1';
                }
                else
                {
                    if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                        boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                        boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                        boxes[12].IsChecked == false && boxes[13].IsChecked == false && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                        boxes[16].IsChecked == false && boxes[17].IsChecked == true && boxes[18].IsChecked == false && boxes[19].IsChecked == false &&
                        boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == false &&
                        boxes[24].IsChecked == true && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == true)
                    {
                        return '2';
                    }
                    else
                    {
                        if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                        boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                        boxes[8].IsChecked == false && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                        boxes[12].IsChecked == false && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                        boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                        boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                        boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                        {
                            return '3';
                        }
                        else
                        {
                            if (boxes[0].IsChecked == true && boxes[1].IsChecked == false && boxes[2].IsChecked == false && boxes[3].IsChecked == false &&
                                boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == true && boxes[7].IsChecked == false &&
                                boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == true && boxes[11].IsChecked == false &&
                                boxes[12].IsChecked == true && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == true &&
                                boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == true && boxes[19].IsChecked == false &&
                                boxes[20].IsChecked == false && boxes[21].IsChecked == false && boxes[22].IsChecked == true && boxes[23].IsChecked == false &&
                                boxes[24].IsChecked == false && boxes[25].IsChecked == false && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                            {
                                return '4';
                            }
                            else
                            {
                                if (boxes[0].IsChecked == true && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == true &&
                                    boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == false &&
                                    boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == false &&
                                    boxes[12].IsChecked == true && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                                    boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                                    boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                                    boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                                {
                                    return '5';
                                }
                                else
                                {
                                    if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                                        boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                                        boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == false &&
                                        boxes[12].IsChecked == true && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                                        boxes[16].IsChecked == true && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                                        boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                                        boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                                    {
                                        return '6';
                                    }
                                    else
                                    {
                                        if (boxes[0].IsChecked == true && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == true &&
                                            boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                                            boxes[8].IsChecked == false && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                                            boxes[12].IsChecked == false && boxes[13].IsChecked == false && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                                            boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == true && boxes[19].IsChecked == false &&
                                            boxes[20].IsChecked == false && boxes[21].IsChecked == true && boxes[22].IsChecked == false && boxes[23].IsChecked == false &&
                                            boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == false && boxes[27].IsChecked == false)
                                        {
                                            return '7';
                                        }
                                        else
                                        {
                                            if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                                                boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                                                boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                                                boxes[12].IsChecked == false && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == false &&
                                                boxes[16].IsChecked == true && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                                                boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                                                boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                                            {
                                                return '8';
                                            }
                                            else
                                            {
                                                if (boxes[0].IsChecked == false && boxes[1].IsChecked == true && boxes[2].IsChecked == true && boxes[3].IsChecked == false &&
                                                    boxes[4].IsChecked == true && boxes[5].IsChecked == false && boxes[6].IsChecked == false && boxes[7].IsChecked == true &&
                                                    boxes[8].IsChecked == true && boxes[9].IsChecked == false && boxes[10].IsChecked == false && boxes[11].IsChecked == true &&
                                                    boxes[12].IsChecked == false && boxes[13].IsChecked == true && boxes[14].IsChecked == true && boxes[15].IsChecked == true &&
                                                    boxes[16].IsChecked == false && boxes[17].IsChecked == false && boxes[18].IsChecked == false && boxes[19].IsChecked == true &&
                                                    boxes[20].IsChecked == true && boxes[21].IsChecked == false && boxes[22].IsChecked == false && boxes[23].IsChecked == true &&
                                                    boxes[24].IsChecked == false && boxes[25].IsChecked == true && boxes[26].IsChecked == true && boxes[27].IsChecked == false)
                                                {
                                                    return '9';
                                                }
                                                else
                                                {
                                                    return '_';
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //---checkboxes---
        //---randomizer---
        private void rndNumberGet(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            _rndNumber = "";
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                _rndNumber += rnd.Next(9);
            }
            randomText.Text = _rndNumber;
            rndYourNumber.Text = $"Ваш номер телефона:\n";
        }
        private void rndNumberSet(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string yourNumber = "+7(";
            char[] rndChars = _rndNumber.ToCharArray();
            int j = 0;
            for (int i = 0; i < 14; i++)
            {
                yourNumber = i == 3 ? yourNumber += ')' : (i == 4 || i == 8 || i == 11 ? yourNumber += '-' : yourNumber += rndChars[j]);
                j = (i != 3 && i != 4 && i != 8 && i != 11) ? ++j : j;
            }
            rndYourNumber.Text = $"Ваш номер телефона:\n {yourNumber}";
        }
        //---randomizer---
    }
}