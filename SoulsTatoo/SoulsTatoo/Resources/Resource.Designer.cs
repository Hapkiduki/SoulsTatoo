﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoulsTatoo.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SoulsTatoo.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Email.
        /// </summary>
        public static string EmailPlaceholder {
            get {
                return ResourceManager.GetString("EmailPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Forgot Password?.
        /// </summary>
        public static string ForgotPass {
            get {
                return ResourceManager.GetString("ForgotPass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Login.
        /// </summary>
        public static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Login with.
        /// </summary>
        public static string LoginWith {
            get {
                return ResourceManager.GetString("LoginWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Logout.
        /// </summary>
        public static string Logout {
            get {
                return ResourceManager.GetString("Logout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a My Profile.
        /// </summary>
        public static string MyProfile {
            get {
                return ResourceManager.GetString("MyProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Password.
        /// </summary>
        public static string PasswordPlaceholder {
            get {
                return ResourceManager.GetString("PasswordPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Sign In.
        /// </summary>
        public static string Register {
            get {
                return ResourceManager.GetString("Register", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Remember me.
        /// </summary>
        public static string Rememberme {
            get {
                return ResourceManager.GetString("Rememberme", resourceCulture);
            }
        }
    }
}