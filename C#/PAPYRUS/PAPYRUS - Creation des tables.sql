CREATE TABLE Produits(
   id_Prod VARCHAR(50),
   libelle VARCHAR(50),
   stock_phys INT,
   stock_alert INT,
   qt_annuelle INT,
   unite_mesure VARCHAR(100),
   PRIMARY KEY(id_Prod)
);

CREATE TABLE Fournisseurs(
   id_F INT IDENTITY,
   nom VARCHAR(100) NOT NULL,
   vile VARCHAR(80) NOT NULL,
   contact VARCHAR(100) NOT NULL,
   satisfaction SMALLINT,
   num_rue INT NOT NULL,
   nom_rue VARCHAR(100) NOT NULL,
   code_postal INT NOT NULL,
   PRIMARY KEY(id_F)
);

CREATE TABLE Commandes(
   id INT,
   observations VARCHAR(50) NOT NULL,
   date_commande DATE NOT NULL,
   id_F INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(id_F) REFERENCES Fournisseurs(id_F)
);

CREATE TABLE Ligne_Commandes(
   id_Linge INT,
   qt_commande SMALLINT NOT NULL,
   prix_commande DECIMAL(15,2) NOT NULL,
   qt_Livree SMALLINT,
   derniers_livraison DATE,
   id_Prod VARCHAR(50),
   id INT,
   PRIMARY KEY(id_Linge),
   FOREIGN KEY(id_Prod) REFERENCES Produits(id_Prod),
   FOREIGN KEY(id) REFERENCES Commandes(id)
);

CREATE TABLE Produit_Fournisseures(
   id_Prod VARCHAR(50),
   id_F INT,
   delais_livraison SMALLINT,
   prix VARCHAR(50),
   qt INT,
   PRIMARY KEY(id_Prod, id_F),
   FOREIGN KEY(id_Prod) REFERENCES Produits(id_Prod),
   FOREIGN KEY(id_F) REFERENCES Fournisseurs(id_F)
);
