# SAE 2.01

      <UserControl x:Class="newPizza.usCommandeEnCours"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:newPizza"  xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             mc:Ignorable="d" 
             d:DesignHeight="200" d:DesignWidth="800">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="1*" />
            <ColumnDefinition Width="4*"/>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="3*"/>
            <RowDefinition Height="2*"/>
        </Grid.RowDefinitions>
        <Rectangle StrokeThickness="1" Stroke="Gray" RadiusX="50" RadiusY="50" Grid.ColumnSpan="2" Grid.RowSpan="3">
            <Rectangle.Fill>
                <SolidColorBrush Opacity="0.9" Color="Gray"/>
            </Rectangle.Fill>
        </Rectangle>
        <Image x:Name="imgPizCommandeEnCours" Source="..\img\pizzas\epicees\spicy_hot_one.jpeg" Grid.Row="0" Margin="40,0,0,0" Grid.RowSpan="3" Height="120"/>
        <WrapPanel Margin="0,0,200,0" Grid.Row="0" Grid.Column="1" VerticalAlignment="Bottom" HorizontalAlignment="Center">
            <TextBlock FontSize="20" Text="Voici les ingrédient de la pizza "/>
            <TextBlock FontSize="20" x:Name="nomPizzaEncours" Text="XXXXXXX"/>
        </WrapPanel>
        <Border Margin="0,20,0,0" Grid.Row="1" Grid.Column="1" Height="100" BorderBrush="Black">
            <Border Height="68" Width="1050" BorderBrush="Black" BorderThickness="1,1,1,1" HorizontalAlignment="Left">
                <ScrollViewer>
                    <TextBlock x:Name="textPizza" Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse &#xA;lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum &#xA;ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. &#xA;Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam."/>
                </ScrollViewer>
            </Border>
        </Border>
        <TextBlock Text="En cours..." HorizontalAlignment="Right" VerticalAlignment="Center" Margin="0,0,260,0" Grid.Row="2" Grid.Column="1" FontSize="25"/>
        <Button HorizontalAlignment="Right" Margin="0,0,40,0" Grid.Row="2" Grid.Column="1" Width="200" Height="50" Cursor="Hand" FontSize="25">FINIR</Button>
    </Grid>
</UserControl>
