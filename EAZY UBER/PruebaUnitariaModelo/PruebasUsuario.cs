﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mundo;
using System.Linq;
using Excepciones;
using System.Collections;

namespace PruebaUnitariaModelo
{
    [TestClass]
    public class PruebasUsuario
    {
        private SistemaRecomendaciones sist;

        /**
         * Escenario con usuarios inicializados para comprobar el funcionamiento de
         * los metodos: agregarVehiculo y agregarRuta ademas que se hagan correctamente las
         * validaciones de los parametros de los metodos.
         */
        private void setup1() {
            sist = new SistemaRecomendaciones();
            sist.registrarUsuario("vito", "corleone", "padrino@correo.mafia.com", "3015584448", "", "del0al9", "del0al9",   true);
            sist.registrarUsuario("michael", "corleone", "padrino2@correo.mafia.com",  "3068455597", "", "del10al20", "del10al20",  true);
            sist.registrarUsuario("fredo", "corleone", "casipadrino@correo.mafia.com",  "3095488541", "", "del20al30", "del20al30",  true);
            sist.registrarUsuario("vincent", "corleone", "falsopadrino@correo.mafia.com", "3326555887", "", "de40a50", "de40a50",  true);
        }

        /**
         *Escenario con usuarios inicializiados con 0 o mas rutas y 0 o mas vehiculos
         * Para comprobar que se garantizen las restricciones de agregar recorridos
         */
        private void setup2(){
            setup1();
            Usuario vito = sist.darUsuario("3015584448");
            vito.registrarVehiculo("GFB469", "Azul", "Cayenne", "fffff");
            vito.registrarVehiculo("NGJ985", "Negro", "Cadilac", "ffff");
            vito.registrarRuta("El peaje", new Tuple<double, double>(95.544, 56.2255), new Tuple<double, double>(105.658, 86.485), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) },"holaaaaaa");

            Usuario michael = sist.darUsuario("3068455597");
            michael.registrarVehiculo("MKL598", "Blanco", "Toyota", "fffff");
            michael.registrarVehiculo("CRL656", "Gris", "Ford", "fffff");

            Usuario vincent = sist.darUsuario("3326555887");
            vincent.registrarRuta("El teatro", new Tuple<double, double>(45.365, 69.265), new Tuple<double, double>(98.254, 35.365), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(52.698, 59.333), new Tuple<double, double>(91.365, 42.365) }, "Buena la Obra, triste el final");
            vincent.registrarRuta("La calles saza", new Tuple<double, double>(33.254, 71.951), new Tuple<double, double>(94.365, 38.985), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(48.658, 55.355), new Tuple<double, double>(89.451, 38.923) }, "obraaaaa");

        }

        [TestMethod]
        public void TestAgregarVehiculo()
        {            
            setup2();
            Assert.AreEqual("GFB469", sist.darUsuario("3015584448").darVehiculoPorPlaca("GFB469").Placa);
            Assert.AreEqual("MKL598", sist.darUsuario("3068455597").darVehiculoPorPlaca("MKL598").Placa);

        }

        [TestMethod]
        public void TestAgregarVehiculoExcepciones(){
            setup1();
            string placa = "HPH434", color = "", modelo = "Cayenne", rutaFoto = "";
            try
            {
                placa = "HPH434"; color = ""; modelo = "Cayenne"; rutaFoto = "";
                sist.darUsuario("3015584448").registrarVehiculo(placa, color, modelo, rutaFoto);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarVehiculoExcepcion), "Excepcion esperada");
            }

            try
            {
                placa = "KLO656"; color = "Morado"; modelo = ""; rutaFoto = "";
                sist.darUsuario("3015584448").registrarVehiculo(placa, color, modelo, rutaFoto);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarVehiculoExcepcion), "Excepcion esperada");

            }
            placa = "MNL089"; color = "Morado"; modelo = "rolls"; rutaFoto = "ffffff";
            Assert.IsTrue(sist.darUsuario("3015584448").registrarVehiculo(placa, color, modelo, rutaFoto));

        }

        
        

        [TestMethod]
        public void TestAgregarRuta()
        {           
            setup2();
            Usuario carlos = sist.darUsuario("3015584448");
            carlos.registrarRuta("El teatro 2", new Tuple<double, double>(45.365, 69.265), new Tuple<double, double>(98.254, 35.365), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(52.698, 59.333), new Tuple<double, double>(91.365, 42.365) }, "Buena la Obra, triste el final");
            carlos.registrarRuta("La calles saza 2", new Tuple<double, double>(33.254, 71.951), new Tuple<double, double>(94.365, 38.985), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(48.658, 55.355), new Tuple<double, double>(89.451, 38.923) }, "kakaaaaaaa");

            Assert.IsTrue(carlos.Rutas.Where(n=>n.Nombre.SequenceEqual("El teatro 2"))!=null);
            Assert.IsTrue(carlos.Rutas.Where(n => n.Nombre.SequenceEqual("La calles saza 2")) != null);

            //Assert.IsTrue(carlos.Rutas.Contains(new Ruta("El teatro 2", new Tuple<double, double>(45.365, 69.265), new Tuple<double, double>(98.254, 35.365), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(52.698, 59.333), new Tuple<double, double>(91.365, 42.365) }, "Buena la Obra, triste el final")));
            //Assert.IsTrue(carlos.Rutas.Contains(new Ruta("La calles saza 2", new Tuple<double, double>(33.254, 71.951), new Tuple<double, double>(94.365, 38.985), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(48.658, 55.355), new Tuple<double, double>(89.451, 38.923) }, "")));

        }

        public void TestAgregarRutaExcepciones() { 
            setup1();
            string nombre = "ruta 1", descripcion = "";
            Tuple<double, double>  ini = new Tuple<double, double>(95.544, 56.2255), fin = new Tuple<double, double>(105.658, 86.485);
            System.Collections.Generic.List< Tuple<double, double>>  puntos = new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) };
            sist.darUsuario("3015584448").registrarRuta(nombre, ini, fin, puntos, descripcion);
            try
            {
                nombre = "ruta 1"; descripcion = "";
                ini = null;
                fin = new Tuple<double, double>(105.658, 86.485);
                puntos = new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) };
                sist.darUsuario("3015584448").registrarRuta(nombre, ini, fin, puntos, descripcion);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarRutaExcepcion), "Excepcion esperada");
            }

            try
            {
                nombre = "ruta 1"; descripcion = "";
                ini = new Tuple<double, double>(95.544, 56.2255);
                fin = null;
                puntos = new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) };
                sist.darUsuario("3015584448").registrarRuta(nombre, ini, fin, puntos, descripcion);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarRutaExcepcion), "Excepcion esperada");
            }

            

            //Agrega la ruta con nombre ruta 1
            nombre = "ruta 1"; descripcion = "";
            ini = new Tuple<double, double>(95.544, 56.2255);
            fin = new Tuple<double, double>(105.658, 86.485);
            puntos = new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) };
            sist.darUsuario("3015584448").registrarRuta(nombre, ini, fin, puntos, descripcion);

            //Verifica que no hayan rutas con el nombre repetido
            try
            {
                nombre = "ruta 1"; descripcion = "";
                ini = new Tuple<double, double>(95.544, 56.2255);
                fin = new Tuple<double, double>(105.658, 86.485);
                puntos = new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(98.544, 66.2255), new Tuple<double, double>(102.65, 76.2255), new Tuple<double, double>(104.695, 82.225) };
                sist.darUsuario("3015584448").registrarRuta(nombre, ini, fin, puntos, descripcion);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarRutaExcepcion), "Excepcion esperada");
            }

        }

        [TestMethod]
        public void TestAgregarRecorrido()
        {
            setup2();
            Usuario carlos = sist.darUsuario("3015584448");
            var hora = DateTime.Today.Hour;
            carlos.registrarRecorrido(2000,3, DateTime.Today, carlos.darVehiculoPorPlaca("NGJ985"), new Ruta("La calles saza 2", new Tuple<double, double>(33.254, 71.951), new Tuple<double, double>(94.365, 38.985), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(48.658, 55.355), new Tuple<double, double>(89.451, 38.923) }, ""));
            Assert.IsNotNull(carlos.Recorridos); 
          }


        [TestMethod]
        public void TestAgregarRecorridoExcepciones(){
            setup2();
            double tarifa=0.0;
            DateTime fecha = DateTime.Now;
            Vehiculo v = sist.darUsuario("3015584448").darVehiculoPorPlaca("GFB469");
            Ruta r = sist.darUsuario("3015584448").Rutas[0];
            

            try
            {
                tarifa = 0.0;
                v = null;
                r = sist.darUsuario("3015584448").Rutas[0];
                sist.darUsuario("3015584448").registrarRecorrido(tarifa, 2,fecha, v, r);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarRecorridoExcepcion), "Excepcion esperada");
            }

            try
            {
                tarifa = 0.0;
                v = sist.darUsuario("3015584448").darVehiculoPorPlaca("GFB469");
                r = null;
                sist.darUsuario("3015584448").registrarRecorrido(tarifa,4, fecha, v, r);
                Assert.Fail("Se debe generar una excepcion por no asignar placa");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarRecorridoExcepcion), "Excepcion esperada");
            }


        }


    }
}
