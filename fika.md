# WPF Menürendszer és Fülkezelés

## Feladat:

Solution neve: **Wpf_1_menuk**

Projekt leírása: WPF alkalmazás menükkel fülekkel és kontextuális menüvel

Működés:

1. Főmenüsáv Fájl és Súgó opciókkal
2. Két lap (Tab) különböző tartalommal
3. Jobb klikk menü Másolás/Beillesztés funkciókkal

## XAML kód:
```c#
<Window x:Class="Wpf_1_menuk.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Wpf_1_menuk"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">

    <DockPanel>
        <Menu DockPanel.Dock="Top">
            <MenuItem Header="_Fájl">
                <MenuItem Header="_Új" Click="New_Click"/>
                <MenuItem Header="_Kilépés" Click="Exit_Click"/>
            </MenuItem>
            <MenuItem Header="_Súgó">
                <MenuItem Header="_Névjegy" Click="About_Click"/>
            </MenuItem>
        </Menu>

        <TabControl DockPanel.Dock="Top">
            <TabItem Header="Első fül">
                <StackPanel Margin="10">
                    <TextBlock Text="Ez az első fül tartalma." Margin="0 0 0 10"/>
                    <Button Content="Kattints ide" Click="Button1_Click"/>
                </StackPanel>
            </TabItem>
            <TabItem Header="Második fül">
                <StackPanel Margin="10">
                    <TextBlock Text="Ez a második fül tartalma." Margin="0 0 0 10"/>
                    <Button Content="Kattints rám is" Click="Button2_Click"/>
                </StackPanel>
            </TabItem>
        </TabControl>
    </DockPanel>
    
    <Window.ContextMenu>
        <ContextMenu>
            <MenuItem Header="Másolás" Click="Copy_Click"/>
            <MenuItem Header="Beillesztés" Click="Paste_Click"/>
        </ContextMenu>
    </Window.ContextMenu>
</Window>
```
## C# kód:
```c#
using System.Windows;

namespace Wpf_1_menuk
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Menü események
        private void New_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Új fájlt hoztál létre");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ez egy egyszerű WPF alkalmazás", "Névjegy");
        }

        // Tab gombok
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Az első gombot nyomtad meg");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A második gombot nyomtad meg");
        }

        // Kontextuális menü
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Másolás");
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beillesztés");
        }
    }
}
```
## Funkciók:

1. Fájl menü

    - Új: Új fájl létrehozása
    - Kilépés: Alkalmazás bezárása

2. Súgó menü

    - Névjegy: Alkalmazás információ

3. Fülkezelés

    - Első fül gombja
    - Második fül gombja

4. Jobb klikk menü

    - Másolás funkció
    - Beillesztés funkció
