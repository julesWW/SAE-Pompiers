# SAE Pompiers - Gestion de Casernes

## Le projet

Une application de gestion de casernes de pompiers en C# avec interface WinForms.\
Il s'agit d'une application permettant au personnel de gérer le personnel, le matériel et les missions de leur caserne. L'application permet de créer des missions, affecter  les ressources nécessaires, de suivre l'état des engins et du personnel, et de générer des statistiques détaillées.

## Techniques utilisées et développement
Programmation orientée objet en .NET C# et WinForms, avec base de données SQLite.\
Ce projet a été réalisé avec ![Lohan Marchand](https://github.com/Lohan-Marchand) et ![Liam Guilleux--Riff](https://github.com/Saduso)

## Installation
1. Télécharger le repo (qui contient le code source du projet)
2. L'ouvrir dans Visual Studio
3. Lancer l'application en cliquant sur le bouton ▶️ en haut de l'interface de Visual Studio

## Fonctionnalités

### Volet 1 : Tableau de bord des missions

Le tableau de bord affiche l'ensemble des missions passées et en cours.

**Fonctionnalités principales :**
- Visualisation de toutes les missions avec leurs statuts
- Clôture des missions au retour des pompiers
- Génération de PDF de bilan de mission
- Mode déconnecté pour la consultation, mode connecté pour les mises à jour (pour la base de données)

**Informations affichées pour chaque mission :**
- Date et heure de la mission
- Type de sinistre
- Caserne affectée
- Statut (en cours / terminée)
- Équipe et engins mobilisés

### Volet 2 : Création d'une nouvelle mission

Ce volet sert à créer et gérer les interventions.

**Processus de création :**
1. Saisir les informations de base :
   - Date de la mission (par défaut : date du jour)
   - Type de sinistre (feu d'appartement, feu de broussailles, ascenseur bloqué, etc.)
   - Caserne initiale

2. Affecter :
   - Les engins nécessaires selon le type de sinistre
   - Les pompiers disponibles possédant les habilitations requises
   - Une caserne alternative si les engins ne sont pas disponibles dans la caserne choisie

**Règles d'affectation :**
- Seuls les pompiers non affectés à une mission en cours sont sélectionnés
- Les habilitations des pompiers sont vérifiées automatiquement et doivent correspondre aux exigences de la mission
- Si un engin n'est pas disponible, le système cherche dans les autres casernes
- Une mission peut être déclenchée avec une équipe incomplète si nécessaire

**Clôture de mission :**
- Mise à jour en mode connecté dans la base de données
- Génération automatique d'un PDF récapitulatif

### Volet 3 : Parcours des équipements

Visualisation détaillée des engins de chaque caserne en mode "1 à 1".

**Caractéristiques d'un engin :**
- Type d'engin
- Numéro d'identification
- Date de réception
- État actuel (disponible / en réparation / en mission)

**Navigation :**
- Boutons avant/arrière pour parcourir les engins
- Liaison de données sans accès direct à la base
- Filtrage par caserne

### Volet 4 : Gestion du personnel

Gestion complète des pompiers.

**Informations gérées pour chaque pompier :**
- Données personnelles (nom, prénom, date de naissance, etc.)
- Statut
- Caserne d'affectation actuelle
- Grade actuel (Sapeur 2ème classe, Sergent, Lieutenant, Capitaine, etc.)
- Habilitations obtenues avec dates d'obtention
- Statut de disponibilité

**Fonctionnalités :**
- Consultation par caserne
- Ajout de nouveaux pompiers
- Mise à jour des informations (réservée aux administrateurs)
- Gestion transactionnelle pour garantir l'intégrité des données

**Sécurité :**
- Vérification des droits dans la table Admin
- Transactions pour les modifications (grade, affectation, congé)

### Volet 5 : Statistiques pour le régulateur

Création de rapports et d'analyse statistique en mode connecté.

**Statistiques par caserne :**
- Engins les plus utilisés
- Nombre total d'heures d'utilisation par engin (classement décroissant)

**Statistiques globales (toutes casernes) :**
- Nombre d'interventions par type de sinistre
- Habilitations les plus sollicitées
- Liste des pompiers par habilitation (y compris les habilitations sans pompier)

### Base de données

L'application utilise une base SQLite (`SDIS67.db`) structurée autour des tables principales :

**Tables principales :**
- **Caserne** : informations sur les 4 casernes
- **Pompier** : données du personnel
- **Grade** : hiérarchie des grades
- **Affectation** : historique des affectations
- **Habilitation** : certifications requises
- **PossederHabilitation** : habilitations par pompier
- **TypeEngin** : catégories d'engins
- **Engin** : matériel disponible
- **TypeSinistre** : catégories d'interventions
- **Mission** : interventions effectuées
- **ParticipeMission** : pompiers mobilisés par mission
- **NecessiteEngin** : engins requis par mission
- **Admin** : droits d'administration

**Classe de connexion :**

Utilisation d'une classe `Connexion.cs` centralisée pour la gestion de l'ouverture et fermeture des connexions à la base de données.

**Classe de données :**

Utilisation d'une classe `mesDatas.cs` pour stocker et partager le DataSet entre les différents formulaires.

### Génération de PDF

L'application génère automatiquement des rapports de mission au format PDF contenant :
- Informations de la mission (date, type, caserne)
- Liste des pompiers mobilisés
- Engins utilisés
- Durée de l'intervention
- Observations éventuelles

### Architecture de l'application

**Modes de fonctionnement :**
- **Mode déconnecté** : consultation des données via DataSet local (volets 1 et 3)
- **Mode connecté** : modifications directes dans la base (volets 2, 4 et 5)

**Bonnes pratiques appliquées :**
- Séparation des responsabilités (formulaires, données, connexion)
- Utilisation de liaisons de données
- Transactions pour l'intégrité des données
- Contrôle des droits d'accès
- Code commenté et lisible

## Remarques techniques

- Le code est structuré, commenté et maintenable
- La gestion des erreurs prend en compte les cas limites (équipe incomplète, engins indisponibles, etc.)
