
DATA PERSISTENCE FOLDER
=======================

This folder should be used to hold data persistence classes such as the
Reader/Writer objects or any helper classes used for ORM using a framework
such as EF Core.

Although it's suggested that the use of Reader and Writer classes makes sense
in the short term (for consistency), in the long term EF Core is likely to make
more sense.

Adopting EF Core would probably require changes to the structure of the classes
in the Model folder, since relationships would be managed via object attributes
rather than primary key IDs.

This folder has been provided as a reminder of how vertical slices through the
Rarify application should be structured, with each veritical slice being a
self-contained microservice that can be included in a monolith application, as
Rarify is at this point in time.

This approach facilitates restructuring at a later date.

It's also worth considering whether to refactor the Liquibase plugin for Surveys
into this project, since the Model classes are tightly integrated with the
Liquibase scripts for Surveys. This is a medium term goal rather than a short
term goal.