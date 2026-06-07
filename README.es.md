# TFG Aplicación de Realidad Virtual

> **Language / Idioma:** [English](README.md) | Español

Aplicación de entrenamiento en Realidad Virtual desarrollada como parte del Trabajo de Fin de Grado (TFG) en la EPSEVG. Simula un escenario de Prevención de Riesgos Laborales (PRL) en el que los usuarios deben seguir el protocolo de actuación ante una emergencia de incendio dentro de un entorno de oficina virtual.

## Proyectos del TFG

Este repositorio es uno de los tres componentes que forman el TFG:

| Proyecto | Descripción | Repositorio |
|---|---|---|
| **API** | Backend REST, gestión de base de datos | [Ver repositorio](https://github.com/Danifeeerr/TFG-database-API) |
| **Aplicación de escritorio** | Cliente de administración | [Ver repositorio](https://github.com/Danifeeerr/VRdashboard-TFG) |
| **Aplicación de Realidad Virtual** (este repo) | Aplicación principal de entrenamiento | — |

---

## Tecnologías

- **Unity** (C#)
- **Meta XR SDK** + **Oculus Interaction SDK**
- **Newtonsoft.Json** para parseo de JSON
- **UnityWebRequest** para comunicación con la API

## Requisitos previos

- Unity 2022.3 LTS o superior con el módulo **Android Build Support** instalado
- Visor Meta Quest 2 / 3 / Pro
- [Meta Quest Developer Hub](https://developer.oculus.com/downloads/package/oculus-developer-hub-win/) o ADB para desplegar en el dispositivo
- Acceso VPN a la red del servidor (necesario para las llamadas a la API)

## Instalación

```bash
# Clonar el repositorio
git clone https://github.com/Danifeeerr/occupational-safety-TFG
```

Abre el proyecto en Unity Hub añadiendo la carpeta clonada. Unity importará todos los paquetes automáticamente.

## Configuración

La URL base de la API se define en `Assets/Scripts/Controllers/ApiController.cs`:

```csharp
private const string BASE_URL = "http://<ip-del-servidor>:8000";
```

Actualiza este valor para que apunte a tu servidor antes de compilar.

## Compilación

1. Abre **File → Build Settings**
2. Cambia la plataforma a **Android**
3. Activa el **Modo desarrollador** en tu visor Meta Quest
4. Conecta el visor por USB y haz clic en **Build and Run**

---

## Funcionalidades

### Autenticación
- Inicio de sesión de usuarios mediante la API REST usando tokens JWT
- La sesión persiste entre escenas con un `ApiController` singleton

### Tutorial
- Tutorial interactivo en RV que enseña los controles: locomoción, teletransporte, coger objetos, pulsar botones y accionar palancas
- Tres salas dedicadas a distintos tipos de interacción

### Entrenamiento PRL
- Protocolo de emergencia de incendio con pasos secuenciales definidos en un archivo JSON
- Validación de pasos con registro de errores
- Indicadores guían al usuario en el orden correcto
- Las acciones incorrectas provocan reinicios e incrementan el contador de errores

### Resultados
- Al completar el entrenamiento, el intento se envía automáticamente a la API con el tiempo empleado y el número de errores

### Soporte multiidioma
- Catalán, castellano e inglés
- Idioma seleccionable desde el menú de opciones

---

## Pasos del protocolo

El protocolo de entrenamiento se define en `Assets/Scripts/Controllers/Protocol.json` y puede modificarse sin cambiar ningún código:

```json
{
    "steps": [
        "Find the alarm and the extinguisher",
        "Turn on the fire alarm",
        "Grab the extinguisher",
        "Arrive to the end of the simulation",
        "Leave the extinguisher at the reunion point"
    ]
}
```
