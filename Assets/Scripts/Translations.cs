using System;
using System.Collections.Generic;

public static class Translations
{
    public static event Action OnLanguageChanged;
    private static readonly Dictionary<string, Dictionary<string, string>> _STRINGS = new()
    {
        ["ca"] = new Dictionary<string, string>
        {
            //Menu de login
            ["login_title"] = "Inici de sessió",
            ["username_placeholder"] = "Nom d'usuari",
            ["pass_placeholder"] = "Contrasenya",
            ["login_button"] = "Entrar",

            //Menu principal 
            ["main_menu_title"] = "Entrenament PRL en RV",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Entrenament",
            ["main_options_button"] = "Opcions",
            ["log_out_button"] = "Tanca sessió",

            //Menu opcions lobby
            ["options_title"] = "Opcions",
            ["master_volume_lbl"] = "Volum general",
            ["music_volume_lbl"] = "Volum música",
            ["sfx_volume_lbl"] = "Volum efectes",
            ["joystick_mvm_label"] = "Moviment amb palanca",
            ["smooth_cam_label"] = "Camera suau",
            ["return_button"] = "Torna",

            ["resume_button"] = "Continuar",
            ["go_lobby_button"] ="Lobby",

            ////////////////////////Targetes////////////////////////
            ["next_card"] = "Seguent",
            ["prevoius_card"] = "Enrere",
            ["close_card"] = "Tancar",
            ///TutorialIntroduction///
            ["tut_int_1"] = "Benvingut al tutorial del sistema d'entrenament per PRL! En aquesta sala podras trobar diverses formes d'aprendre a utilitzar els controls en Realitat Virtual com agafar objectes, accionar botons i palanques o colocar objectes així com moure't!",
            ["tut_int_2"] = "Davant teu hi han tres sales amb un contingut diferent cadascuna. A la sala número 1 aprendràs a accioanr palanques i botons, a la 2 a col·locar objectes i a la 3 podràs repasar els controls tant de moviment com d'interacció.",
            ["tut_int_3"] = "Primer pots provar a interactuar amb els objectes que hi han a la taula amb els gallets inferiors dels teus controladors. Prova a agafar els objectes, girar-los, llençar-los... Familiaritza't amb l'interacció en Realitat Virtual!",
            
            ["room1_intr1"] = "En aquesta sala podràs aprendre com s'han de col·locar els diferents objectes dins dels seus llocs. Veuràs que hi han objectes opacs i d'altres transparents. Pots interactuar amb els que són opacs i els transparents són els llocs a on els has de posar.",
            ["room1_intr2"] = "Quan col·loquis un objecte dins del seu espai, hauràs de comprovar que el teu controlador vibra. Si es així, vol dir que el sistema reconeix que l'has posat correctament i llavors el pots deixar anar, i veuràs com l'bjecte es recoloca sol!",
            ["room2_intr"] = "En aquesta sala podràs provar a accionar diversos botons i palanques. Aquests mecanismes poden ser accionats passant la ma com si ho fessis a la vida real! Prova a apropar la ma als botons i palanques i veuras com reaccionen!",
            ["room3_intr"] = "En aquesta sala podràs repasar els diferents controls als que pots accedir en aquesta experiència. Si tens cap problema amb els teus controladors o el teu visor de Realitat Virtual, contacta amb els serveis d'IT i t'ajudaran el més ràpid possible!",

            ["room1_tips"] = "Recorda, si els teus controladors no vibren, vol dir que encara no has aconseguit posar la peça en la posició correcta, segueix girant la peça dins de la zona transparent fins que sentis la vibració i llavors podràs deixar-la anar! Veuràs que per l'esfera i el cilindre és especialment útil.",
            ["room2_button1"] = "Has apretat el botó!",
            ["room2_lever1"] = "¡Has accionat la palanca!",
            
            ["room3_tut1"] = "Per moure el teu avatar digital simulant que estàs caminant, acciona la palanqueta del teu controlador esquerre. Aquest tipus de moviment pot ser deshabilitat des del menú d'opcions.",

    


        },
        ["es"] = new Dictionary<string, string>
        {
            //Menu de login
            ["login_title"] = "Inicia sesión",
            ["username_placeholder"] = "Nombre de usuario",
            ["pass_placeholder"] = "Contraseña",
            ["login_button"] = "Entrar",

            //Menu principal 
            ["main_menu_title"] = "Entrenamiento PRL en RV",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Entrenamiento",
            ["main_options_button"] = "Opciones",
            ["log_out_button"] = "Cerrar sesión",

            //Menu opciones lobby
            ["options_title"] = "Opciones",
            ["master_volume_lbl"] = "Volumen general",
            ["music_volume_lbl"] = "Volumen música",
            ["sfx_volume_lbl"] = "Volumen efectos",
            ["joystick_mvm_label"] = "Movimiento con palanca",
            ["smooth_cam_label"] = "Camara suave",
            ["return_button"] = "Volver",

            ["resume_button"] = "Continuar",
            ["go_lobby_button"] ="Lobby",

            ////////////////////////Tarjetas////////////////////////
            ["next_card"] = "Siguiente",
            ["prevoius_card"] = "Atrás",
            ["close_card"] = "Cerrar",
            ///TutorialIntroduction///
            ["tut_int_1"] = "Bienvenido al tutorial del sistema de entrenamiento para PRL! En esta sala podras encontrar varias formas de aprender a utilizar los controles en Realidad Virtual como coger objectos, accionar botones y palancas o colocar objetos así como moverte!",
            ["tut_int_2"] = "Delante de ti hay tres salas con un contenido diferente cada una. En la sala 1 aprenderás a accionar palancas y botones, en la 2 a colocar objetos y en la 3 podrás repasar los controles tanto de movimiento como de interacción.",
            ["tut_int_3"] = "Primero puedes probar a interactuar con los objetos que tienes en la mesa con los gatillos inferiores de tus mandos. Prueba a coger los objetos, girarlos, lanzarlos... Familiarizate con la interacción en Realidad Virtual!",

            ["room1_intr1"] = "En esta sala podrás aprender cómo se deben colocar los diferentes objetos en sus lugares. Verás que hay objetos opacos y otros transparentes. Puedes interactuar con los que son opacos y los transparentes son los lugares donde los debes colocar.",
            ["room1_intr2"] = "Cuando coloques un objeto dentro de su espacio, deberás comprobar que tu mando vibra. Si es así, significa que el sistema reconoce que lo has colocado correctamente y entonces puedes soltarlo, y verás como el objeto se recoloca solo!",
            ["room2_intr"] = "En esta sala podrás probar a accionar diversos botones y palancas. Estos mecanismos pueden ser accionados pasando la mano como si lo hicieras en la vida real! Prueba a acercar la mano a los botones y palancas y verás como reaccionan!",
            ["room3_intr"] = "En esta sala podrás repasar los diferentes controles a los que puedes acceder en esta experiencia. Si tienes algún problema con tus mandos o tu visor de Realidad Virtual, contacta con los servicios de IT y te ayudarán lo más rápido posible!",

            ["room1_tips"] = "Recuerda, si tus mandos no vibran, quiere decir que todavía no has conseguido poner la pieza en la posición correcta. Sigue girandola dentro de la zona transparente hasta que sientas la vibración y entonces podrás dejarla! Verás que para la esfera y el cilindro es especialmente útil.",
            ["room2_button1"] = "¡Has apretado el botón!",
            ["room2_lever1"] = "¡Has accionado la palanca!",

            ["room3_tut1"] = "Para mover tu avatar digital simulando que estas caminando, acciona la palanca de tu mando izquierdo. Este tipo de movimiento puede ser deshabilitado des del menú de opciones.",


            



        },
        ["en"] = new Dictionary<string, string>
        {
            //Login menu
            ["login_title"] = "Log in",
            ["username_placeholder"] = "Username",
            ["pass_placeholder"] = "Password",
            ["login_button"] = "Enter",

            //Main menu
            ["main_menu_title"] = "VR OHS Training",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Training",
            ["main_options_button"] = "Options",
            ["log_out_button"] = "Log out",

            //Options lobby menu
            ["options_title"] = "Options",
            ["master_volume_lbl"] = "Master volume",
            ["music_volume_lbl"] = "Music volume",
            ["sfx_volume_lbl"] = "SFX volume",
            ["joystick_mvm_label"] = "Joystick movement",
            ["smooth_cam_label"] = "Smooth camera",
            ["return_button"] = "Return",

            ["resume_button"] = "Resume",
            ["go_lobby_button"] ="Lobby",

            ////////////////////////Text cards////////////////////////
            ["next_card"] = "Next",
            ["prevoius_card"] = "Back",
            ["close_card"] = "Close",
            ///TutorialIntroduction///
            ["tut_int_1"] = "Welcome to the OHS training system tutorial! Here you can find some ways of learning how to use your Virtual Reality Controls for grabbing objects, pressing buttons and operating levers or placing objects as well as moving around!",
            ["tut_int_2"] = "In front of you, you will find three rooms with different contents. In the room number 1 you will learn to operate buttons and levers, in the 2nd you will learn to place objects and in the 3rd one you can review movement and interaction controls.",
            ["tut_int_3"] = "First, you can try interacting with the table objects with your controller's bottom triggers. Try grabbing those objects, turning them, throwing them... Get familiar with the Virtual Reality interactions!",

            ["room1_intr1"] = "In this room you will learn how to place the different objects in their spots. You will notice that some objects are opaque and others are transparent. You can interact with the opaque ones and the transparent ones are the spots where you need to place them.",
            ["room1_intr2"] = "When you place an object inside its space, you should check that your controller vibrates. If it does, it means the system recognizes that you have placed it correctly and then you can let it go, and you will see how the object repositions itself!",
            ["room2_intr"] = "In this room you will be able to try operating various buttons and levers. These mechanisms can be activated by passing your hand as if you were doing it in real life! Try bringing your hand close to the buttons and levers and you will see how they react!",
            ["room3_intr"] = "In this room you will be able to review the different controls you can access in this experience. If you have any issues with your controllers or your Virtual Reality headset, contact IT services and they will help you as soon as possible!",

            ["room1_tips"] = "Remember, if your controllers are not vibrating, that means you have not placed the piece in the correct position. Keep rotating it inside the transparent zone until you feel the vibration and then you can let it go! You will find this especially useful for the sphere and the cylinder.",
            
            ["room2_button1"] = "You pressed the button!",
            ["room2_lever1"] = "You pulled the lever!",

            ["room3_tut1"] = "To move your digital avatar as if you were walking, moev your left controller's joystick. This type of movement can be disabled from you options menu.",

        },
    };

    public static string Get(string key)
    {
        string lang = SettingsManager.Instance != null ? SettingsManager.Instance.Settings.lang : "ca";
        if (_STRINGS.TryGetValue(lang, out var dict) && dict.TryGetValue(key, out var value))
            return value;
        if (_STRINGS["ca"].TryGetValue(key, out var fallback))
            return fallback;
        return key;
    }

    public static void SetLang(string lang)
    {
        if (!_STRINGS.ContainsKey(lang)) return;
        SettingsManager.Instance.Settings.lang = lang;
        SettingsManager.Instance.Save();
        OnLanguageChanged?.Invoke();
    }

    public static string GetLang() => SettingsManager.Instance.Settings.lang;
}