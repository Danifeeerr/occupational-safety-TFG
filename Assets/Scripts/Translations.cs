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
            ["tut_int_3"] = "Primer pots provar a apropar-te amb la palanqueta esquerra i interactuar amb els objectes que hi han a la taula amb els gallets inferiors dels teus controladors. Prova a agafar els objectes, girar-los, llençar-los... Familiaritza't amb l'interacció en Realitat Virtual!",
            ["tut_int_4"] = "Si en algun moment no pots girar la càmera o no pots moure't amb les palanquetes, probablement estiguis apuntant a una de les capses de text. Deixa d'apuntar i torna a probar!",

            ["room1_intr1"] = "En aquesta sala podràs aprendre com s'han de col·locar els diferents objectes dins dels seus llocs. Veuràs que hi han objectes opacs i d'altres transparents. Pots interactuar amb els que són opacs i els transparents són els llocs a on els has de posar.",
            ["room1_intr2"] = "Quan col·loquis un objecte dins del seu espai, hauràs de comprovar que el teu controlador vibra. Si es així, vol dir que el sistema reconeix que l'has posat correctament i llavors el pots deixar anar, i veuràs com l'bjecte es recoloca sol!",
            ["room2_intr"] = "En aquesta sala podràs provar a accionar diversos botons i palanques. Aquests mecanismes poden ser accionats passant la ma com si ho fessis a la vida real! Prova a apropar la ma als botons i palanques i veuras com reaccionen!",
            ["room3_intr"] = "En aquesta sala podràs repasar els diferents controls als que pots accedir en aquesta experiència. Si tens cap problema amb els teus controladors o el teu visor de Realitat Virtual, contacta amb els serveis d'IT i t'ajudaran el més ràpid possible!",

            ["room1_tips"] = "Recorda, si els teus controladors no vibren, vol dir que encara no has aconseguit posar la peça en la posició correcta, segueix girant la peça dins de la zona transparent fins que sentis la vibració i llavors podràs deixar-la anar! Veuràs que per l'esfera i el cilindre és especialment útil.",
            ["room2_button1"] = "Has apretat el botó!",
            ["room2_lever1"] = "¡Has accionat la palanca!",

            ["room3_tut1"] = "Per moure el teu avatar digital simulant que estàs caminant, acciona la palanqueta del teu controlador esquerre. Aquest tipus de moviment pot ser deshabilitat des del menú d'opcions.",
            ["room3_tut2"] = "Per teletransportar-te per l'espai virtual, acciona la palanca dreta cap endevant, apunta a on vols apréixer i deixa anar la palanqueta. Apareixeràs a on has apuntat al instant!",
            ["room3_tut3"] = "Per obrir el menú d'opcions has d'apretar el botó de menú del teu controlador esquerre. T'apareixerà un menú sobre la mà esquerra que podràs controlar amb la ma dreta!",
            ["room3_tut4"] = "Pots girar la càmera tant movent el cap físicament com accionant la palanqueta del teu controlador dret cap a l'esquerra i la dreta. Des del menú d'opcions pots fer que el moviment amb palanqueta sigui per cops per no marejar-te.",
            ["room3_tut5"] = "Per agafar objectes de l'escenari virtual has d'apretar els gatells inferiors dels teus controladors. Posa el controlador dins de l'objecte que vols agafar i presiona els gatells, veuràs que fàcil!",
            ["room3_tut6"] = "Pots agafar objectes a distància si apuntes cap a ells amb el teu controlador i l'agafes amb els gatells inferiors. Has d'apuntar amb la punta mes llunyana a la teva ma del controlador.",

            ["tr_int_1"] = "Benvingut a l'enetrenament del protocol de cas d'incendi! Primer de tot, assegura't d'haver llegit el protocol abans d'intentar l'entrenament per minimitzar els errors. Al teu voltant trobaràs tot el necessàri.",
            ["tr_int_2"] = "Recorda que pots fer el tutorial abans de l'entrenament per familiartizar-te amb els controls de la simulació. Si no l'has fet ja, pots pressionar el botó menú del teu controlador esquerra i tornar al lobby per iniciar el tutorial.",
            ["tr_int_3"] = "Cada error compta! Pel que vols fer el mínim d'errors possible. Compta com a error tant entrar en una sala a la que no has d'entrar, com fer un pas del protocol en un ordre incorrecte. Bona sort!",

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
            ["tut_int_3"] = "Primero puedes probar a acercarte con la palanca izquierda y interactuar con los objetos que tienes en la mesa con los gatillos inferiores de tus mandos. Prueba a coger los objetos, girarlos, lanzarlos... Familiarizate con la interacción en Realidad Virtual!",
            ["tut_int_4"] = "Si en algun momento no puedes girar la cámara o moverte con las palancas, probablemente estés apuntando a una caja de texto. ¡Deja de apuntarla y vuelve a probar!",

            ["room1_intr1"] = "En esta sala podrás aprender cómo se deben colocar los diferentes objetos en sus lugares. Verás que hay objetos opacos y otros transparentes. Puedes interactuar con los que son opacos y los transparentes son los lugares donde los debes colocar.",
            ["room1_intr2"] = "Cuando coloques un objeto dentro de su espacio, deberás comprobar que tu mando vibra. Si es así, significa que el sistema reconoce que lo has colocado correctamente y entonces puedes soltarlo, y verás como el objeto se recoloca solo!",
            ["room2_intr"] = "En esta sala podrás probar a accionar diversos botones y palancas. Estos mecanismos pueden ser accionados pasando la mano como si lo hicieras en la vida real! Prueba a acercar la mano a los botones y palancas y verás como reaccionan!",
            ["room3_intr"] = "En esta sala podrás repasar los diferentes controles a los que puedes acceder en esta experiencia. Si tienes algún problema con tus mandos o tu visor de Realidad Virtual, contacta con los servicios de IT y te ayudarán lo más rápido posible!",

            ["room1_tips"] = "Recuerda, si tus mandos no vibran, quiere decir que todavía no has conseguido poner la pieza en la posición correcta. Sigue girandola dentro de la zona transparente hasta que sientas la vibración y entonces podrás dejarla! Verás que para la esfera y el cilindro es especialmente útil.",
            ["room2_button1"] = "¡Has apretado el botón!",
            ["room2_lever1"] = "¡Has accionado la palanca!",

            ["room3_tut1"] = "Para mover tu avatar digital simulando que estas caminando, acciona la palanca de tu mando izquierdo. Este tipo de movimiento puede ser deshabilitado des del menú de opciones.",
            ["room3_tut2"] = "Para teletransportarte por el espacio virtual, acciona la palanca derecha hacia delante, apunta donde quieres aparecer y deja la palanca. Aparecerás en el lugar al que has apuntado al instante!",
            ["room3_tut3"] = "Para abrir el menú de opciones, presiona el botón de menú de tu mando izquierdo. Te aparecerá un menú sobre la mano izquierda que podrás controlar apuntando con la mano derecha.",
            ["room3_tut4"] = "Puedes girar la cámara tanto moviendo la cabeza físicamente como accionando la palanca de tu mando derecgo hacia la izquierda y la derecha. Des del menú de opciones puedes hacer que el movimiento con palanca sea por golpecitos para no marearte.",
            ["room3_tut5"] = "Para agarrar objetos del escenario virtual tienes que presionar los gatillos inferiores de tus mandos. Pon el controlador en el objeto que quieres agarrar i presiona el gatillo, ¡verás que fácil!",
            ["room3_tut6"] = "Puedes agarrar objetos a distancia si apuntas hacia ellos con tu mando y presionas el gatillo inferior. Tienes que apuntar con la punta mas lejana de tu mano al mando.",

            ["tr_int_1"] = "¡Bienvenido al entrenamiento del protocolo de caso de incendio! Antes de nada, asegúrate de haber leído el protocolo antes de intentar el entrenamiento para minimizar los errores. A tu alrededor encontrarás todo lo necesario.",
            ["tr_int_2"] = "Recuerda que puedes hacer el tutorial antes del entrenamiento para familiarizarte con los controles de la simulación. Si aún no lo has hecho, puedes presionar el botón menú de tu mando izquierdo y volver al lobby para iniciar el tutorial.",
            ["tr_int_3"] = "¡Cada error cuenta! Por lo que quieres cometer el mínimo de errores posible. Cuenta como error tanto entrar en una sala a la que no debes entrar, como realizar un paso del protocolo en un orden incorrecto. ¡Buena suerte!",

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
            ["tut_int_3"] = "First, you can try approaching the table with the left joystick and interacting with the table objects with your controller's bottom triggers. Try grabbing those objects, turning them, throwing them... Get familiar with the Virtual Reality interactions!",
            ["tut_int_4"] = "If you can not move your camera or your own body with your joysticks, you are probably pointing at one of the text boxes. Stop pointing at it and try again!",

            ["room1_intr1"] = "In this room you will learn how to place the different objects in their spots. You will notice that some objects are opaque and others are transparent. You can interact with the opaque ones and the transparent ones are the spots where you need to place them.",
            ["room1_intr2"] = "When you place an object inside its space, you should check that your controller vibrates. If it does, it means the system recognizes that you have placed it correctly and then you can let it go, and you will see how the object repositions itself!",
            ["room2_intr"] = "In this room you will be able to try operating various buttons and levers. These mechanisms can be activated by passing your hand as if you were doing it in real life! Try bringing your hand close to the buttons and levers and you will see how they react!",
            ["room3_intr"] = "In this room you will be able to review the different controls you can access in this experience. If you have any issues with your controllers or your Virtual Reality headset, contact IT services and they will help you as soon as possible!",

            ["room1_tips"] = "Remember, if your controllers are not vibrating, that means you have not placed the piece in the correct position. Keep rotating it inside the transparent zone until you feel the vibration and then you can let it go! You will find this especially useful for the sphere and the cylinder.",

            ["room2_button1"] = "You pressed the button!",
            ["room2_lever1"] = "You pulled the lever!",

            ["room3_tut1"] = "To move your digital avatar as if you were walking, moev your left controller's joystick. This type of movement can be disabled from you options menu.",
            ["room3_tut2"] = "To teleport through the virtual environment, move your right's controller joystick forward, point towards wherever you want to appear and let the jostick go. You will appear there at the moment!",
            ["room3_tut3"] = "To open the options menu, press the menu button in your left controller. A floating menú will appear over your left hand and you will be able to interact with it with your right hand.",
            ["room3_tut4"] = "You can turn your camera moving your head and moving your right controller's joystick from left to right. In the options menu you can change the joystick movement to be less smooth so that you don't get sick.",
            ["room3_tut5"] = "To grab objects in the virtual world you must press the bottom triggers in your controller. Put your controller in the object you want to grab and press the trigger, as easy as that!",
            ["room3_tut6"] = "You can grab objects from a distance if you point at them and press the trigger. You must point them with the farest point of the controller to your hand.",

            ["tr_int_1"] = "Welcome to the fire emergency protocol training! First of all, make sure you have read the protocol before attempting the training to minimize mistakes. Around you, you will find everything you need.",
            ["tr_int_2"] = "Remember that you can do the tutorial before the training to get familiar with the simulation controls. If you haven't done it yet, you can press the menu button on your left controller and return to the lobby to start the tutorial.",
            ["tr_int_3"] = "Every mistake counts! So you want to make as few errors as possible. Entering a room you should not enter and performing a protocol step in the wrong order both count as errors. Good luck!",

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
