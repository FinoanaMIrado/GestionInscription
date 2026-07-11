# GestionInscription
# E-School 🎓

## Présentation du projet

E-School est une application desktop de gestion d’inscription scolaire développée avec **C# .NET Windows Forms**.

L’application permet aux établissements scolaires de gérer efficacement le processus d’inscription des élèves, depuis la saisie des informations dans un formulaire jusqu’à l’enregistrement en base de données, la gestion des paiements et l’attribution des élèves dans leurs classes.

Le projet a pour objectif de remplacer les processus manuels par une solution numérique simple, rapide et organisée.

## Objectifs du projet

- Digitaliser la gestion des inscriptions scolaires
- Faciliter l’enregistrement et la recherche des informations élèves
- Assurer le suivi des paiements scolaires
- Organiser la répartition des élèves par classe
- Améliorer la gestion administrative d’un établissement

## Technologies utilisées

### Application Desktop
- **C#** : Langage de programmation principal
- **.NET Framework / .NET** : Plateforme de développement
- **Windows Forms (WinForms)** : Création de l’interface graphique
- **Visual Studio** : Environnement de développement

### Base de données
- **MySQL** : Système de gestion de base de données
- **MySQL Connector/NET** : Connexion entre l’application et la base de données

### Outils
- **MySQL Workbench** : Administration et conception de la base de données
- **Git & GitHub** : Gestion de version

## Fonctionnalités principales

### Gestion des élèves
- Formulaire d’inscription scolaire
- Ajout, modification et suppression des élèves
- Consultation des informations des élèves
- Recherche rapide des dossiers

### Gestion des inscriptions
- Enregistrement des nouvelles inscriptions
- Attribution d’un identifiant élève
- Gestion des informations scolaires

### Gestion des paiements
- Enregistrement des frais scolaires
- Suivi du statut de paiement
- Historique des paiements effectués

### Gestion des classes
- Création et gestion des classes
- Attribution des élèves dans une classe
- Affichage de la liste des élèves par classe
# Base de données

La base de données **gestion_inscriptions** est composée de six tables principales permettant la gestion des élèves, des classes, des inscriptions, des paiements, des récépissés et des utilisateurs.

## Tables

### Élève
Contient les informations des élèves.

| Champ | Type | Description |
|-------|------|-------------|
| Matricule | VARCHAR(20) (PK) | Identifiant de l'élève |
| Nom | VARCHAR(50) | Nom |
| Prenom | VARCHAR(50) | Prénom |
| Pere | VARCHAR(100) | Nom du père |
| Mere | VARCHAR(100) | Nom de la mère |
| Tuteur | VARCHAR(100) | Tuteur de l'élève |
| Adresse | VARCHAR(150) | Adresse |
| DateNaiss | DATE | Date de naissance |

---

### Classe
Contient les informations sur les classes.

| Champ | Type | Description |
|-------|------|-------------|
| CodeClasse | VARCHAR(10) (PK) | Code de la classe |
| LibelleClasse | VARCHAR(50) | Nom de la classe |
| Niveau | VARCHAR(30) | Niveau scolaire |

---

### Inscription
Enregistre les inscriptions des élèves.

| Champ | Type | Description |
|-------|------|-------------|
| NumeroInscription | INT (PK) | Numéro d'inscription |
| DateInscription | DATE | Date d'inscription |
| AnneeScolaire | VARCHAR(20) | Année scolaire |
| Matricule | VARCHAR(20) (FK) | Élève inscrit |
| CodeClasse | VARCHAR(10) (FK) | Classe choisie |

---

### Paiement
Enregistre les paiements des frais d'inscription.

| Champ | Type | Description |
|-------|------|-------------|
| NumPaiement | INT (PK) | Numéro du paiement |
| DatePaiement | DATE | Date du paiement |
| Montant | DECIMAL(10,2) | Montant payé |
| ModePaiement | VARCHAR(30) | Mode de paiement |
| NumeroInscription | INT (FK) | Inscription concernée |

---

### Récépissé
Conserve les récépissés générés après paiement.

| Champ | Type | Description |
|-------|------|-------------|
| NumRecepisse | INT (PK) | Numéro du récépissé |
| DateRecepisse | DATE | Date d'émission |
| NumPaiement | INT (FK) | Paiement associé |

---

### Utilisateurs
Permet l'authentification dans l'application.

| Champ | Type | Description |
|-------|------|-------------|
| IdUtilisateur | INT (PK) | Identifiant |
| nom_utilisateur | VARCHAR(50) | Nom d'utilisateur |
| mot_de_passe | VARCHAR(255) | Mot de passe |

## Relations entre les tables

```text
Élève
   │
   └── Inscription ─── Classe
            │
            └── Paiement
                   │
                   └── Récépissé
```

## Clés primaires

- Élève : `Matricule`
- Classe : `CodeClasse`
- Inscription : `NumeroInscription`
- Paiement : `NumPaiement`
- Récépissé : `NumRecepisse`
- Utilisateurs : `IdUtilisateur`

## Clés étrangères

- `Inscription.Matricule` → `Eleve.Matricule`
- `Inscription.CodeClasse` → `Classe.CodeClasse`
- `Paiement.NumeroInscription` → `Inscription.NumeroInscription`
- `Recepisse.NumPaiement` → `Paiement.NumPaiement`
