# CSharpMediaLibrary

A media library app using sql server (Express, but could be adopted to use standard server)

Made for C#2 class.Currently set up for movie and game libraries, but could easily be adapted to
include additional libraries. Most of the functionality is handled inside of methods created which
take a parameter for a switch statement, to avoid rewriting the same code where possible. So books
and records and everything else could be added in without much effort. I initially was going to 
set it up with more categories, like books, and records, but time became an issue.

There is a config.cs file which contains the connection string. The path to the DB will need to be
changed if you use a local DB file, or the connection string will need changing for use with a server.

Use is fairly simple. Each database is displayed in a different tab, the full contents of the DB are 
displayed by default, but can be filtered using categorized searches. Double clicking any item will
bring up a pane in which you can edit or delete the item.

There is an "Add Media" button in the bottom right which will launch an input form. Items are first
validated and instantiated into a class, which is added to a list. The list is accessible through
a list box. The items can be selected and edited before commiting them. Once committed all items
will be pushed to their respective DBs. You can add multiple categories (Such as movies and games)
within the same session. They can both be committed at once.

