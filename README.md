# SAE 2.01
https://docs.microsoft.com/fr-fr/windows/apps/design/controls/toggles


<DockPanel HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Margin="0">
        <ListBox DockPanel.Dock="Left" Background="Gray" MinWidth="120"/>

        <StackPanel DockPanel.Dock="Top" Background="Red" MinHeight="130" HorizontalAlignment="Stretch">
            <WrapPanel Margin="0,20,0,0" HorizontalAlignment="Center" VerticalAlignment="Center">
                <Image Margin="0,0,10,0" Width="100" Source="/img/buttons/IdPageSmile.jpg"/>
                <TextBlock Text="new Pizza()" VerticalAlignment="Center" FontSize="40" FontWeight="DemiBold"/>
            </WrapPanel>
        </StackPanel>
        <StackPanel Margin="0,20,0,60" HorizontalAlignment="Center" MinWidth="300" MaxWidth="300">
            <TextBox x:Name="idTextBox" materialDesign:HintAssist.Hint="Identifiant" materialDesign:HintAssist.HelperText="entrez votre identifiant" Cursor="IBeam"/>
            <TextBox Margin="0,20,0,0" x:Name="idMail" materialDesign:HintAssist.Hint="E-Mail" materialDesign:HintAssist.HelperText="entrez votre adresse email" Cursor="IBeam"/>
            <PasswordBox Margin="0,20,0,0" x:Name="PasswordBox" materialDesign:HintAssist.Hint="Password" materialDesign:TextFieldAssist.HasClearButton="True" materialDesign:HintAssist.HelperText="Entrez votre mot de passe" Cursor="IBeam"/>

            <Button Margin="0,40,0,0" Content="S'INSCRIRE" Width="260"  MinHeight="30" Background="Gray" BorderBrush="White" FontWeight = "UltraBlack"
                    materialDesign:ShadowAssist.ShadowDepth="Depth2"
                    materialDesign:ButtonProgressAssist.Value="-1"
                    materialDesign:ButtonProgressAssist.IsIndicatorVisible="false"
                    materialDesign:ButtonProgressAssist.IsIndeterminate="false"
                    Cursor="Hand"/>
            <TextBlock HorizontalAlignment="Center" FontSize="12" FontWeight="Regular">
                <Span xml:space="preserve"><Run>Déjà inscrit ? </Run><Hyperlink NavigateUri="pageInscription">Se connecter</Hyperlink></Span>
            </TextBlock>
        </StackPanel>
    </DockPanel>