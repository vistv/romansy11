using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace romansy11
{
    public partial class MainPage : ContentPage
    {
        Label label1 = new Label() { Text = "Кредитка" }; Entry Ent1 = new Entry { Placeholder = "Кредит" };
        Label label2 = new Label() { Text = "Зарплатна" }; Entry Ent2 = new Entry();
        Label label3 = new Label() { Text = "Кеш" }; Entry Ent3 = new Entry();
        Label label4 = new Label() { Text = "Дата" }; Entry Ent4 = new Entry();
        Label label5 = new Label() { Text = "Залишилось днів" }; Entry Ent5 = new Entry();// резалт
        Label label6 = new Label() { Text = "Кінцева дата" }; Entry Ent6 = new Entry();
        Label label7 = new Label() { Text = "Розхід в день" }; Entry Ent7 = new Entry();
        Label label8 = new Label() { Text = "Необхідна сума" }; Entry Ent8 = new Entry();// резалт
        Label label9 = new Label() { Text = "Наявна сума" }; Entry Ent9 = new Entry();// резалт
        Label label10 = new Label() { Text = "Можна тратити" }; Entry Ent10 = new Entry();// резалт
        Label label11 = new Label() { Text = "Толерантний борг" }; Entry Ent11 = new Entry();
        Label label12 = new Label() { Text = "Необхідні витрати" }; Entry Ent12 = new Entry();

        public MainPage()
        {
            Ent5.IsEnabled = false; Ent8.IsEnabled = false; Ent9.IsEnabled = false; //Ent10.IsEnabled = true;

            Ent1.Keyboard = Keyboard.Numeric; Ent2.Keyboard = Keyboard.Numeric; Ent3.Keyboard = Keyboard.Numeric; Ent4.Keyboard = Keyboard.Numeric;
            Ent5.Keyboard = Keyboard.Numeric; Ent6.Keyboard = Keyboard.Numeric; Ent7.Keyboard = Keyboard.Numeric; Ent8.Keyboard = Keyboard.Numeric;
            Ent9.Keyboard = Keyboard.Numeric; Ent10.Keyboard = Keyboard.Numeric; Ent11.Keyboard = Keyboard.Numeric; Ent12.Keyboard = Keyboard.Numeric;

            label1.Font = Font.SystemFontOfSize(NamedSize.Small); label2.Font = Font.SystemFontOfSize(NamedSize.Small); label3.Font = Font.SystemFontOfSize(NamedSize.Small);
            label4.Font = Font.SystemFontOfSize(NamedSize.Small); label5.Font = Font.SystemFontOfSize(NamedSize.Small); label6.Font = Font.SystemFontOfSize(NamedSize.Small);
            label7.Font = Font.SystemFontOfSize(NamedSize.Small); label8.Font = Font.SystemFontOfSize(NamedSize.Small); label9.Font = Font.SystemFontOfSize(NamedSize.Small);
            label10.Font = Font.SystemFontOfSize(NamedSize.Small); label11.Font = Font.SystemFontOfSize(NamedSize.Small); label12.Font = Font.SystemFontOfSize(NamedSize.Small);

            Ent10.TextColor = Color.Red;


            object name = "";
            if (App.Current.Properties.TryGetValue("Кредит.", out name))
            {
                Ent1.Text = (string)App.Current.Properties["Кредит."]; Ent2.Text = (string)App.Current.Properties["Зарпл."]; Ent3.Text = (string)App.Current.Properties["Кеш"];
                Ent4.Text = (string)App.Current.Properties["Дата"]; Ent5.Text = (string)App.Current.Properties["Зал. дн."]; Ent6.Text = (string)App.Current.Properties["Кнц дата"];
                Ent7.Text = (string)App.Current.Properties["Розхід в день"]; Ent8.Text = (string)App.Current.Properties["Необхідна сума"]; Ent9.Text = (string)App.Current.Properties["Наявна сума"];
                Ent10.Text = (string)App.Current.Properties["Мож трат"]; Ent11.Text = (string)App.Current.Properties["Толерантний борг"]; 
            }
            else
            {
                Ent1.Text = "0"; Ent2.Text = "0"; Ent3.Text = "0"; Ent4.Text = "0"; Ent5.Text = "0"; Ent6.Text = "0"; Ent7.Text = "0"; Ent8.Text = "0";
                Ent9.Text = "0"; Ent10.Text = "0"; Ent11.Text = "0"; 
            }


            if (App.Current.Properties.TryGetValue("Необхідні витрати", out name))
            {
                Ent12.Text = (string)App.Current.Properties["Необхідні витрати"];
            }
            else
            {
                Ent12.Text = "0";
            }



            Ent1.TextChanged += loginEntry_TextChanged; Ent2.TextChanged += loginEntry_TextChanged; Ent3.TextChanged += loginEntry_TextChanged; Ent4.TextChanged += loginEntry_TextChanged;
            Ent6.TextChanged += loginEntry_TextChanged; Ent7.TextChanged += loginEntry_TextChanged; Ent11.TextChanged += loginEntry_TextChanged; Ent12.TextChanged += loginEntry_TextChanged;

            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)}
            },
                ColumnDefinitions =
            {
                new ColumnDefinition { },
                new ColumnDefinition { }
            }
            };

            {
                grid.Children.Add(label4, 0, 0); grid.Children.Add(Ent4, 0, 0); grid.Children.Add(label10, 1, 0); grid.Children.Add(Ent10, 1, 0);
                grid.Children.Add(label1, 0, 1); grid.Children.Add(Ent1, 0, 1); grid.Children.Add(label9, 1, 1); grid.Children.Add(Ent9, 1, 1);
                grid.Children.Add(label2, 0, 2); grid.Children.Add(Ent2, 0, 2); grid.Children.Add(label8, 1, 2); grid.Children.Add(Ent8, 1, 2);
                grid.Children.Add(label3, 0, 3); grid.Children.Add(Ent3, 0, 3); grid.Children.Add(label11, 1, 3); grid.Children.Add(Ent11, 1, 3);
                grid.Children.Add(label6, 0, 4); grid.Children.Add(Ent6, 0, 4); grid.Children.Add(label5, 1, 4); grid.Children.Add(Ent5, 1, 4);
                grid.Children.Add(label7, 0, 5); grid.Children.Add(Ent7, 0, 5); grid.Children.Add(label12, 1, 5); grid.Children.Add(Ent12, 1, 5);
                //grid.Children.Add({ label7,  Ent7}, 1,5);
            }




            this.Content = grid;
            this.BackgroundColor = Color.YellowGreen;
        }

        private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {





            // convert text to int 
            int entr1 = ConvertStringToInt(Ent1.Text); //кредит
            int entr2 = ConvertStringToInt(Ent2.Text); //зарпл 
            int entr3 = ConvertStringToInt(Ent3.Text); //кеш
            int entr4 = ConvertStringToInt(Ent4.Text); //дата
            int entr6 = ConvertStringToInt(Ent6.Text); //кінц дата
            int entr7 = ConvertStringToInt(Ent7.Text); //розх в день
            int entr11 = ConvertStringToInt(Ent11.Text); //тол борг
            int entr12 = ConvertStringToInt(Ent12.Text); //Необхідні витрати

            int entr5 = entr6 - entr4; //залиш днів
            int entr8 = entr7 * entr5; //необх сума
            int entr9 = entr2 + (entr1) + entr3; //наявна сума
            int entr10 = entr9 - entr8 + entr11 - entr12; // можна тратити

            Ent5.Text = entr5.ToString();
            Ent8.Text = entr8.ToString();
            Ent9.Text = entr9.ToString();
            Ent10.Text = entr10.ToString();

            {
                App.Current.Properties["Кредит."] = Ent1.Text; App.Current.Properties["Зарпл."] = Ent2.Text; App.Current.Properties["Кеш"] = Ent3.Text;
                App.Current.Properties["Дата"] = Ent4.Text; App.Current.Properties["Зал. дн."] = Ent5.Text; App.Current.Properties["Кнц дата"] = Ent6.Text;
                App.Current.Properties["Розхід в день"] = Ent7.Text; App.Current.Properties["Необхідна сума"] = Ent8.Text; App.Current.Properties["Наявна сума"] = Ent9.Text;
                App.Current.Properties["Мож трат"] = Ent10.Text; App.Current.Properties["Толерантний борг"] = Ent11.Text; App.Current.Properties["Необхідні витрати"] = Ent12.Text;
            }
            App.Current.SavePropertiesAsync();
        }

        private int ConvertStringToInt(string intString)
        {
            int i = -1;
            if (!Int32.TryParse(intString, out i))
                return -1;
            else
                return i;

        }
    }

}
