using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mundo;
using Excepciones;
using System.Collections.Generic;

namespace PruebaUnitariaModelo
{
    [TestClass]
    public class PruebasSistRecomendaciones
    {
        private SistemaRecomendaciones mundito;

        /*
         * Escenario sin usuarios registrados
         */
        private void setup1()
        {
            mundito = new SistemaRecomendaciones();            
        }

        /**
         *Escenario con usuarios inicializiados con 0 o mas rutas y 0 o mas vehiculos
         * Para comprobar que se garantizen las restricciones de agregar recorridos
         */
        private void setup2()
        {
            
            mundito = new SistemaRecomendaciones();
            mundito.registrarUsuario("vito", "corleone", "30155844", "del0al9", "padrino@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6988));
            mundito.registrarUsuario("michael", "corleone", "3068455", "del10al20", "padrino2@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6188));
            mundito.registrarUsuario("fredo", "corleone", "3095488541", "del20al30", "casipadrino@correo.mafia.com", "", new Tuple<double, double>(1.2222, 1.6888));
            mundito.registrarUsuario("vincent", "corleone", "33265558", "de40a50", "falsopadrino@correo.mafia.com", "", new Tuple<double, double>(1,1));

            Usuario vito = mundito.darUsuario("30155844");
            vito.registrarVehiculo("GFB469", "Azul", "Cayenne", "");
            vito.registrarVehiculo("NGJ985", "Negro", "Cadilac", "");
            vito.registrarRuta("El peaje", new Tuple<double, double>(-2,0.5), new Tuple<double, double>(3,0.5), null, "");
            vito.registrarRecorrido(3000.00, DateTime.Today, vito.Vehiculos[0], vito.Rutas[0]);
            Usuario michael = mundito.darUsuario("3068455");
            michael.registrarVehiculo("MKL598", "Blanco", "Toyota", "");
            michael.registrarVehiculo("CRL656", "Gris", "Ford", "");
            michael.registrarRuta("La calle saza", new Tuple<double, double>(1,3), new Tuple<double, double>(3,1), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(1,2), new Tuple<double, double>(2,1) }, "");
            michael.registrarRecorrido(3000.00, DateTime.Today, michael.Vehiculos[0], michael.Rutas[0]);
            Usuario vincent = mundito.darUsuario("33265558");
            vincent.registrarVehiculo("GPL098", "Azul", "Chiron", "");
            vincent.registrarRuta("El teatro", new Tuple<double, double>(-2,2.5), new Tuple<double, double>(2,2), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(2,2.5) }, "Buena la Obra, triste el final");
           vincent.registrarRecorrido(3000.00, DateTime.Today, vincent.Vehiculos[0], vincent.Rutas[0]);
        }

        [TestMethod]
        public void TestRegistrarUsuario() {
            setup1();
            string nombre, apellido, celular, contraseña, correo, rutaFoto;
            Tuple<double, double> ubicacion;         

            try
            {
                nombre = null; apellido = "goras"; celular = "3141516"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }
            try
            {
                nombre = "pita"; apellido = null; celular = "3141516"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = null; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516"; contraseña = null; correo = "larecta@geometria.com"; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516"; contraseña = "sumadecuadrados"; correo = null; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }

            //Registra el usuario
            nombre = "pita"; apellido = "goras"; celular = "3141516"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
            ubicacion = new Tuple<double, double>(1.2222, 1.6588);
            mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);

            //Verifica excepcion para cuando ya existe el usuario
            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, celular, contraseña, correo, rutaFoto, ubicacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AgregarUsuarioExcepcion), "Excepcion esperada");
            }

        }

        [TestMethod]
        public void TestRecomendarRecorridos()
        {
            setup2();
            mundito.loguearUsuario("3095488541");
            Boolean xd = mundito.recomendarRecorridos(mundito.darUsuario("3095488541").Ubicacion);
            String[] nombres = { "vito", "michael", "vincent" };
            int i = 0;
            //Hacer comprobaciones de orden de recorridos, primero vito, segundo michael, tercero vincent
            Assert.AreEqual(3, mundito.Estado_recorridosRecomendados.Count);
            //foreach (keyvaluepair<usuario, recorrido> kvp in mundito.estado_recorridosrecomendados)
            //{
            //    assert.areequal(nombres[i], kvp.key.nombre);
            //    i++;
            //}

             
              
            

        }

        [TestMethod]
        public void TestRecomendarPasajeros()
        {

        }




    }
}
