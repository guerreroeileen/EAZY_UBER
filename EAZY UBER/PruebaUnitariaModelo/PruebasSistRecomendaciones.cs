using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mundo;

namespace PruebaUnitariaModelo
{
    [TestClass]
    public class PruebasSistRecomendaciones
    {
       


        private SistemaRecomendaciones mundito;
        private void setup1()
        {
            mundito = new SistemaRecomendaciones();
            mundito.registrarUsuario("vito", "corleone", "30155844", "del0al9", "padrino@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6588));
            mundito.registrarUsuario("michael", "corleone", "3068455", "del10al20", "padrino2@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6588));
            mundito.registrarUsuario("fredo", "corleone", "3095488541", "del20al30", "casipadrino@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6588));
            mundito.registrarUsuario("vincent", "corleone", "33265558", "de40a50", "falsopadrino@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6588));
        }

        /**
         *Escenario con usuarios inicializiados con 0 o mas rutas y 0 o mas vehiculos
         * Para comprobar que se garantizen las restricciones de agregar recorridos
         */
        private void setup2()
        {
            setup1();
            Usuario vito = mundito.darUsuario("30155844");
            vito.registrarVehiculo("GFB469", "Azul", "Cayenne", "");
            vito.registrarVehiculo("NGJ985", "Negro", "Cadilac", "");
            vito.registrarRuta("El peaje", new Tuple<double, double>(95.544, 56.2255), new Tuple<double, double>(105.658, 86.485), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) }, "");

            Usuario michael = mundito.darUsuario("3068455");
            michael.registrarVehiculo("MKL598", "Blanco", "Toyota", "");
            michael.registrarVehiculo("CRL656", "Gris", "Ford", "");

            Usuario vincent = mundito.darUsuario("33265558");
            vincent.registrarRuta("El teatro", new Tuple<double, double>(45.365, 69.265), new Tuple<double, double>(98.254, 35.365), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(52.698, 59.333), new Tuple<double, double>(91.365, 42.365) }, "Buena la Obra, triste el final");
            vincent.registrarRuta("La calles saza", new Tuple<double, double>(33.254, 71.951), new Tuple<double, double>(94.365, 38.985), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(48.658, 55.355), new Tuple<double, double>(89.451, 38.923) }, "");

        }




    }
}
