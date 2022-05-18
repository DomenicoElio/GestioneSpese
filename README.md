GestioneSpese[Esercitazione-Testo.pdf](https://github.com/DomenicoElio/GestioneSpese/files/8715325/Esercitazione-Testo.pdf)

Realizzare una Console app (C#) che:
• Apra e legga il file “spese.txt”
• Ogni riga è nel formato
Data;Categoria;Descrizione;Importo
Esercitazione
Realizzare una Console app (C#) che:
• Per ogni riga, determini se la spesa è approvata. Esistono
diversi livelli di approvazione, a seconda dell'importo della
spesa
• Manager: spese fino a 400€
• Operational Manager: da 401€ fino a 1000€
• CEO: sopra i 1000€
• Nessuna spesa sopra i 2500€ è approvata
Esercitazione
Realizzare una Console app (C#) che:
• Per ogni spesa approvata, determini l'importo rimborsato sulla
base della Categoria
• Viaggio: 100% dell'importo + 50€ fisse
• Alloggio: 100% dell'importo
• Vitto: 70% dell'importo
• Altro: 10% dell'importo
Esercitazione
Realizzare una Console app (C#) che:
• Salvare poi le informazioni sulle spese rimborsate e non rimborsate in un
file di testo (spese_elaborate.txt)
• Per ogni spesa rimborsata salvare una riga nel formato
• Per ogni spesa non rimborsata salvare una riga nel formato
• (OPZIONALE) Far partire il salvataggio del file mediante l’uso di un
evento
Data;Categoria;Descrizione;RESPINTA;-;-
Data;Categoria;Descrizione;APPROVATA;LvlApprov;ImportoRimborsato
Esercitazione
Realizzare una batteria di test (xUnit) che verifichi la corretta
gestione dei seguenti casi:
Categoria Importo Stato / Lvl Importo Rimborsato
Viaggio 500€ Approvato / OPS 550€
Viaggio 3100€ Non Approvato -
Vitto 1400€ Approvato / CEO 980€
