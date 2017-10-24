using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mundo;
using Excepciones;
using System.Collections.Generic;
using System.IO;

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
            mundito.registrarUsuario("vito", "corleone", "padrino@correo.mafia.com", "3015584448", "", "del0al9", "del0al9",  true);
            mundito.registrarUsuario("michael", "corleone", "padrino2@correo.mafia.com", "3068455487", "", "del10al20", "del10al20",   true);
            mundito.registrarUsuario("fredo", "corleone", "casipadrino@correo.mafia.com", "3095488541", "", "del20al30", "del20al30",   true);
            mundito.darUsuario("3095488541").Ubicacion = new Tuple<double, double>(1.2222, 1.6888);
            mundito.registrarUsuario("vincent", "corleone", "falsopadrino@correo.mafia.com", "3326555884", "", "de40a50", "de40a50",  true);

            Usuario vito = mundito.darUsuario("3015584448");
            vito.registrarVehiculo("GFB469", "Azul", "Cayenne", "");
            vito.registrarVehiculo("NGJ985", "Negro", "Cadilac", "");
            vito.registrarRuta("El peaje", new Tuple<double, double>(-2,0.5), new Tuple<double, double>(3,0.5), null, "");
            vito.registrarRecorrido(3000.00, DateTime.Today, vito.Vehiculos[0], vito.Rutas[0]);
            Usuario michael = mundito.darUsuario("3068455487");
            michael.registrarVehiculo("MKL598", "Blanco", "Toyota", "");
            michael.registrarVehiculo("CRL656", "Gris", "Ford", "");
            michael.registrarRuta("La calle saza", new Tuple<double, double>(1,3), new Tuple<double, double>(3,1), new System.Collections.Generic.List<Tuple<double, double>>() { new Tuple<double, double>(1,2), new Tuple<double, double>(2,1) }, "");
            michael.registrarRecorrido(3000.00, DateTime.Today, michael.Vehiculos[0], michael.Rutas[0]);
            Usuario vincent = mundito.darUsuario("3326555884");
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
                nombre = null; apellido = "goras"; celular = "3326555884"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                mundito.registrarUsuario(nombre, apellido, correo, celular,rutaFoto, contraseña, contraseña,true);
               
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[0] != 1)
                    Assert.Fail();
            }
            try
            {
                nombre = "pita"; apellido = null; celular = "3141516157"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[1] != 1)
                    Assert.Fail();
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = null; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[3] != 1)
                    Assert.Fail();
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516526"; contraseña = null; correo = "larecta@geometria.com"; rutaFoto = "";
                mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[5] != 1)
                    Assert.Fail();
            }

            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516896"; contraseña = "sumadecuadrados"; correo = null; rutaFoto = "";
                ubicacion = new Tuple<double, double>(1.2222, 1.6588);
                mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[2] != 1)
                    Assert.Fail();
            }

            //Registra el usuario
            nombre = "pita"; apellido = "goras"; celular = "3141516159"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
            mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);

            //Verifica excepcion para cuando ya existe el usuario
            try
            {
                nombre = "pita"; apellido = "goras"; celular = "3141516159"; contraseña = "sumadecuadrados"; correo = "larecta@geometria.com"; rutaFoto = "";
                mundito.registrarUsuario(nombre, apellido, correo, celular, rutaFoto, contraseña, contraseña, true);
            }
            catch (AgregarUsuarioExcepcion e)
            {
                if (e.darErrores()[3] != 1)
                    Assert.Fail();
            }

        }

        
        public void TestRecomendarRecorridos()
        {
            setup2();
            mundito.loguearUsuario("3095488541", "del20al30");
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



        [TestMethod]
        public void TestCargar()
        {            
            setup1();
            mundito.guardarDB();
            mundito.cargarDB();
            Assert.IsNotNull(mundito.Usuarios.Exists(n=> n.Celular.Equals("3015584448")));
        }


        



    }
}
