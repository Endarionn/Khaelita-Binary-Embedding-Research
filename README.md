<img width="1224" height="808" alt="9axbr79sa1rmy0cxh2psb92f28" src="https://github.com/user-attachments/assets/0bc26618-ca9a-4281-a807-1413f649c996" />

🧬 Khaelita Binary Embedding Research
A technical research project and Proof-of-Concept implementation of Binary Data Embedding and Stub-Builder architecture, written in C#. This project demonstrates how to inject, store, and extract dynamic configurations within a compiled executable without modifying the source code or recompiling.

⚙️ Project Overview
Khaelita Binary Embedding Research explores the mechanism of appending custom data to the end of a Portable Executable (PE) file, beyond the last section header. This technique allows an application to be "data-driven" while remaining a single, portable binary.

Components
The Builder: A C# WinForms utility that acts as the "compiler" for the configuration. It serializes data into JSON and appends it to the template.

The Stub: A lightweight template executable designed to scan its own binary footprint, find a specific signature (<DATA>), and adapt its behavior based on the discovered payload.

🚀 Use Cases: Why Use Binary Embedding?
This technique is a versatile architectural pattern used in various fields of software engineering:

1. Legitimate Software Engineering
Portable Applications: Storing user preferences or license information directly inside the .exe so the app remains a single file.

Custom Installers: Web installers that embed a unique "Download ID" or "Affiliate Tag" into the binary before the user downloads it.

Game Assets: Small-scale games that embed level data or scripts at the end of the engine executable for fast access.

2. Cybersecurity & Malware Research (Red Teaming)
In the context of cybersecurity, this method is the industry standard for creating modular tools:

C2 Communication: Storing the Command & Control (C2) server IP and Port inside a "Loader" or "Bot" binary without hardcoding it in the source.

Payload Droppers: Embedding an encrypted secondary payload (like a DLL or shellcode) that the stub decrypts and executes in memory.

Unique Identifiers: Generating unique binaries for each target to track infections or bypass simple hash-based detection.

🛠️ Technical Implementation
The "Stitching" Process
The Builder follows these steps to create the output binary:

Read the raw bytes of the Stub.exe.

Serialize the Config object into a UTF-8 JSON string.

Append a Hardcoded Marker (<DATA>) to signal where the data begins.

Append the Data Length (4 bytes) to tell the Stub how much to read.

Append the Actual JSON Data.

The "Extraction" Process (Stub Logic)
The Stub uses a specialized algorithm to locate the data at runtime:

C#
// Logic to find the offset of the embedded data
private int FindMarker(byte[] data, byte[] marker) {
    for (int i = 0; i <= data.Length - marker.Length; i++) {
        // ... byte-by-byte comparison ...
    }
}
📋 Compilation & Setup
Requirements
IDE: Visual Studio 2022

Language: C# / .NET Framework 4.7.2+

Dependency: Newtonsoft.Json

Build Steps
Clone the repository.

Build the Stub project in Release mode.

Ensure Stub.exe is present in the Builder's output directory.

Run Builder.exe, enter your configuration, and click Build.

🛡️ Defensive Perspective (Blue Teaming)
Understanding this technique is crucial for security analysts and incident responders:

Static Analysis: Analysts look for "Overlay" data (data located after the legitimate PE sections) to find hidden configurations.

Entropy Analysis: High entropy at the end of a file often indicates encrypted or compressed embedded payloads.

Signature Detection: Security tools monitor for common markers or JSON structures appended to known legitimate binaries.

⚠️ Legal & Ethical Notice
This project is strictly for educational, ethical research, and software architecture demonstration purposes. The techniques described here are neutral; however, their application in creating unauthorized or harmful software is strictly prohibited. The author is not responsible for any misuse of this information.

📄 License
Distributed under the MIT License. See LICENSE for more information.

🧠 About the Author
Created by Yağız Atalay under the Khaelita security research label. Exploring the boundaries of binary manipulation, system internals, and defensive programming.
