# HappyTech 😀🖥️

### Common Problems

- **Settings page doesn't open.**
1. Close every tab within Visual Studio.
2. Go to Solution Explorer and click on "Happytech" (Above "Properties" in hierarchy, it has an green C# icon).
3. Click on "Clean" and then "Rebuild".
4. Have fun.

- **Database doesn't open.**
1. Go to the base directory and delete `database_log.ldf`.
2. Go to "Server Explorer" and in "Data Connections" remove the connection to the database.
3. Create another connection to the database.
4. Be sure to select `Microsoft SQL Server Database File (SqlClient)`.
5. Select the database that is in `(...)/Happytech/Happytech/database.mdf`.

- **The program doesn't open due to database problems.**
1. Go to Task Manager.
2. Search for every task that could be using the "SQL Server" service.
3. Kill them all, there is no place for them here.
4. They could be:
   * SQL Server Windows NT - 64 Bit, <-- Probably it is this dude here, don't trust him...
   * Node.js: Server-side JavaScript,
   * SQL Server,
   * OBDC Service.
   * And others... I can't remember all of them.
5. If you think killing any of this will break your system, don't worry, mine is running fine.

Happy coding... 😐
