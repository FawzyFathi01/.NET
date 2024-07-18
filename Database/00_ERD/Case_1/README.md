# Company Database E-R Diagram

## Description

A big company has decided to store information about its projects and employees in a database. The company has wisely chosen to hire you as a database designer. Below is the E-R diagram representing the company structure according to the following description:

### Entities and Attributes

1. **Employee**
   - Attributes: SSN, Birth Date, Gender, Name (Fname, Lname)
   - Relationships:
     - Works in several projects (N:M relationship with Project)
     - Has a supervisor (1:1 recursive relationship)
     - Managed by a department (1:M relationship with Department)
     - May have dependents (1:N relationship with Dependent)

2. **Department**
   - Attributes: DName, DNUM (unique), Locations
   - Relationships:
     - Managed by an employee (1:1 relationship with Employee)
     - Has employees (1:M relationship with Employee)
     - Manages projects (1:M relationship with Project)

3. **Project**
   - Attributes: PName, PNumber (unique), Location, City
   - Relationships:
     - Worked on by employees (N:M relationship with Employee)
     - Managed by a department (M:1 relationship with Department)

4. **Dependent**
   - Attributes: Name (unique), Gender, Birth Date
   - Relationships:
     - Dependent of an employee (N:1 relationship with Employee)

### Constraints and Notes

- Each employee may have dependents, but if the employee leaves the company, there is no need to store the dependent's information.
- For each department, there is always one employee assigned to manage that department, and each manager has a hiring date.
- An employee must work in only one department, but a department may have multiple employees.
- Each project is assigned to one department, but a department may have multiple projects.
- Each employee can work on several projects, and each project can have several employees. Each employee has a number of working hours in each project.
- Each employee has a supervisor.

### E-R Diagram

![E-R Diagram](image.jpg)

The diagram shows the relationships between the entities and the attributes of each entity. The multiplicity of each relationship is also depicted, indicating whether the relationship is one-to-one, one-to-many, or many-to-many.
