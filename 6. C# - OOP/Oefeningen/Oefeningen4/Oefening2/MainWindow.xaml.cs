﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //## Oefening 2

        //Maak onderstaande oefening in WPF.
        //Zorg ervoor dat we een ongelimiteerd aantal werknemers kunnen aanmaken. Voorzie dus een lijst van werknemers.\
        //In een bedrijf werken drie soorten werknemers: arbeiders, bedienden en kaderleden. Ontwerp voor ieder een aparte klasse.\
        //Alle **werknemers** hebben een voornaam en een naam.\
        //**Arbeiders** ontvangen een uurloon daarom is het belangrijk om voor iedere arbeider bij te houden het aantal gewerkte uren in 
        //de afgelopen maand.\
        //**Bedienden** en **kaderleden** krijgen een maandwedde uitbetaald en ontvangen maaltijdcheques. Het aantal maaltijdcheques komt overeen met het aantal gewerkte dagen.\
        //**Kaderleden** hebben recht op een bedrijfswagen. Van de kaderleden wordt bijgehouden welk type auto ze hebben.\
        //Maak gebruik van overerving bij het oplossen van deze oefening.
        public MainWindow()
        {
            InitializeComponent();
            Werknemer werknemer = new Werknemer("Maarten", "De Beuf");
            Bediende bediende = new Bediende("Kim", "Stichelbout");
            bediende.GepresteerdeDagenMaand = 5;
            Arbeider arbeider = new Arbeider("Lyen", "De Beuf");
            arbeider.GepresteerdeUrenMaand = 120;
            Kaderlid kaderlid = new Kaderlid("Maarten", "De Beuf", "Volkswagen");
            kaderlid.GepresteerdeDagenMaand = 6;

        }
    }
}
