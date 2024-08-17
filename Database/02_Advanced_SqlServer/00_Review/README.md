- Intro 
	#Database :- Collection related data 
	#Database_Management_System :- Software Package to creation and Maintenance Computerized Database 
	#Database_System :- (Software + Database )

	![[Pasted image ٢٠٢٤٠٨١٦٠٦١٢٠٩.png]]

- ERD 
	1. Entity (Strong ,Weak)
	2. Attributes (Simple ,Composite ,Multi Valued ,Complex ,Derived)
	3. Relationship (Degree ,Cardinality ,Participation) 
- Mapping 
	1. Relationship 
	 1. 1:1
		- 2 Mandatory              --> one Table Any Primary key
		- Optional-Mandatory  --> Two Table  ( #id_optional is FK in #Mandatory)
		- 2 Optional                  --> Three Table (new table Any Primary Key)
	 3. 1:M
		- M Mandatory             --> Two Table ( #id_1 is FK in #M)
		- M Optional                 --> Three Table ( new Table #id_m is Primary Key )
	 4. M:M
		- Three Table --> new Table Composite Primary Key 
	2. Entity 
		- Weak Entity --> one table Composite primary Key (Id_Weak , Id_Strong)
	3. Attribute 
	 - Multi Valued,complex --> New Table Composite Primary Key 
- DDL
- DML
- DQL 

---


