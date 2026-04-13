<img width="1224" height="808" alt="9axbr79sa1rmy0cxh2psb92f28" src="https://github.com/user-attachments/assets/75ba90db-d979-4e90-8130-cb317c15ac44" />

# 🧬 Khaelita Binary Embedding Research

> **Proof-of-Concept implementation of Binary Data Embedding and Stub-Builder architecture.**
> *Written in pure C# for educational and research purposes.*

---

## ⚙️ Project Overview

**Khaelita Binary Embedding Research** focuses on the technical mechanism of appending custom configuration data to the end of a Portable Executable (PE) file. This allows a pre-compiled binary (Stub) to act dynamically based on the data injected by a secondary tool (Builder).

---

### 🛠️ Core Components

| Component | Description |
| :--- | :--- |
| **The Builder** | A WinForms utility that serializes configuration into JSON and appends it to the binary. |
| **The Stub** | The payload/client that reads itself at runtime to extract the hidden configuration. |

---

### 🚀 Technical Scenarios & Use Cases

#### 1. Legitimate Software Design
- **Single-File Portability:** Storing license keys or user settings directly in the `.exe`.
- **Custom Deployments:** Embedding unique deployment IDs in web-installers.

#### 2. Red Teaming & Malware Research (Educational)
- **C2 Configuration:** Malware loaders often use this "Overlay" technique to store Command & Control server addresses without hardcoding them.
- **Payload Droppers:** Embedding encrypted secondary files at the end of the PE file to be decrypted in memory.

---

### 🔬 How It Works (Step-by-Step)

1.  **Serialization:** Builder converts inputs into a minified JSON string.
2.  **Stitching:** The Builder copies the `Stub.exe` and appends a 6-byte marker `<DATA>`, followed by the data length, and the JSON payload.
3.  **Self-Analysis:** Upon execution, the Stub locates the marker within its own byte array.
4.  **Dynamic Execution:** The extracted config is applied to the UI or logic in real-time.

---

### 🛡️ Defensive Perspective (Blue Teaming)

- **Overlay Detection:** Security tools check if the file size on disk is larger than the size specified in the PE header.
- **Entropy Analysis:** Encrypted data appended to the end of a file results in high entropy, signaling hidden payloads.

---

### ⚠️ Legal Notice

This software is provided for **educational, ethical research, and awareness purposes only**. Any unauthorized use or deployment of this tool in real-world environments may violate laws. The author takes **no responsibility** for misuse.

---

### 📄 License

MIT License — Use, modify, learn. Respect the knowledge.

---

### 🧠 About
Created by Yağız Atalay under the Khaelita security research label. Made to explore, understand, and help secure real-world privilege escalation vectors.
