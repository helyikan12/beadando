# Control-ok (-CheckBox +Tooltip +TabIndex,RadioButton)

## A program:

Projekt neve: **wpf_szerda**

Projekt leírás: A projekt egy wpf alkalmazást mutat be ami lehetővé teszi a felhasználók számára hogy beállítsák az értesítéseket és válasszanak világos vagy sötét témát, ezt a CheckBox és RadioButton Control-ok használatával Tooltip és TabIndex funkciók alkalmazásával

Projekt működése:
1. CheckBox (Értesítések):
 - A felhasználó be és kikapcsolhatja az értesítéseket a CheckBox segítségével,ha be van jelölve az értesítések aktívak ha nincs akkor nem
 - A Tooltip segítségével a felhasználó információt kap arról hogy mit csinál ha az egérmutatót a control fölé viszi
2. RadioButton (Téma választás):
 - A felhasználó választhat a kéttő közül: Világos vagy Sötét
 - A RadioButton control-ok közül az egyik mindig kiválasztva van és a felhasználó a másikra kattintva váltani tud a két téma között
3. TabIndex (Navigáció):
 - A TabIndex beállítása biztosítja hogy a felhasználó billentyűzetről is könnyedén navigálhasson a vezérlők között például a Tab billentyű segítségével
4. Gomb (Beállítások alkalmazása):
 - Az "Alkalmaz" gomb megnyomásával az alkalmazás egy üzenetablakot jelenít meg ami tartalmazza a felhasználó által kiválasztott beállításokat

<details>
<summary>Behind code</summary>

```c#
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_szerda;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void ApplySettings_Click(object sender, RoutedEventArgs e)
    {
        string message = "Beállítások:\n";
        if (chkNotify.IsChecked == true)
        {
            message += "- Értesítések bekapcsolva\n";
        } 
        else
        {
            message += "- Értesítések kikapcsolva\n";
        }    
        if (rdoLightMode.IsChecked == true)
        {
            message += "- Világos téma kiválasztva";
        }  
        else if (rdoDarkMode.IsChecked == true)
        {
            message += "- Sötét téma kiválasztva";
        }
        MessageBox.Show(message, "Beállítások mentve");
    }
}
```
</details>

<details>
<summary>xaml</summary>

```xml
<Window x:Class="wpf_szerda.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:wpf_szerda"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <CheckBox x:Name="chkNotify" Content="Értesítések bekapcsolása"
                  ToolTip="Kapcsolja be vagy ki az értesítéseket"
                  TabIndex="0" Margin="10,10,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <TextBlock Text="Válasszon témát:" Margin="10,50,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <RadioButton x:Name="rdoLightMode" Content="Világos" IsChecked="True"
                     TabIndex="1" Margin="10,70,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <RadioButton x:Name="rdoDarkMode" Content="Sötét"
                     TabIndex="2" Margin="10,90,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <Button Content="Alkalmaz" Width="100" Height="30"
                Click="ApplySettings_Click"
                TabIndex="3" Margin="10,130,0,0" HorizontalAlignment="Left" VerticalAlignment="Top"/>
    </Grid>
</Window>
```
</details>
