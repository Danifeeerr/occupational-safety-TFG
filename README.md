# TFG VR Application

> **Language / Idioma:** English | [Español](README.es.md)

Virtual Reality training application developed as part of a university Final Degree Project (TFG) at EPSEVG. It simulates an occupational health and safety (OHS) scenario in which users must follow a fire emergency protocol inside a virtual office environment.

## TFG Projects

This repository is one of three components that make up the TFG:

| Project | Description | Repository |
|---|---|---|
| **API** | REST backend, database management | [View repository](https://github.com/Danifeeerr/TFG-database-API) |
| **Desktop Application** | Administration client | [View repository](https://github.com/Danifeeerr/VRdashboard-TFG) |
| **Virtual Reality Application** (this repo) | Main training application | — |

---

## Tech Stack

- **Unity** (C#)
- **Meta XR SDK** + **Oculus Interaction SDK**
- **Newtonsoft.Json** for JSON parsing
- **UnityWebRequest** for API communication

## Prerequisites

- Unity 2022.3 LTS or newer with **Android Build Support** module installed
- Meta Quest 2 / 3 / Pro headset
- [Meta Quest Developer Hub](https://developer.oculus.com/downloads/package/oculus-developer-hub-win/) or ADB for device deployment
- VPN access to the backend network (required for API calls)

## Installation

```bash
# Clone the repository
git clone https://github.com/Danifeeerr/occupational-safety-TFG
```

Open the project in Unity Hub by adding the cloned folder. Unity will import all packages automatically.

## Configuration

The API base URL is defined in `Assets/Scripts/Controllers/ApiController.cs`:

```csharp
private const string BASE_URL = "http://<server-ip>:8000";
```

Update this value to point to your API server before building.

## Building

1. Open **File → Build Settings**
2. Switch platform to **Android**
3. Enable **Developer Mode** on your Meta Quest headset
4. Connect the headset via USB and click **Build and Run**

---

## Features

### Authentication
- User login via the REST API using JWT tokens
- Session persists across scenes with a singleton `ApiController`

### Tutorial
- Interactive VR tutorial teaching the controls: locomotion, teleportation, grabbing objects, pressing buttons and levers
- Three dedicated rooms covering different interaction types

### OHS Training
- Fire emergency protocol with sequential steps defined in a JSON file
- Step validation with error tracking
- Indicators guide the user through the correct order
- Wrong actions trigger resets and increment the mistake counter

### Results
- On completion, the attempt is automatically sent to the API including time spent and number of errors

### Multilingual Support
- Catalan, Spanish, and English
- Language selectable from the options menu

---

## Protocol Steps

The training protocol is defined in `Assets/Scripts/Controllers/Protocol.json` and can be modified without changing any code:

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
