# taskManager

download the code to your local repository(I used Visual Studio to create this Windows Form App)

connect to a database from your ide

use the following sql statements to create a database compatible with this code:

Make the item table

CREATE TABLE `tms`.`itemtable` ( `itemID` INT NOT NULL AUTO_INCREMENT , `itemName` TEXT NOT NULL , `itemDetail` TEXT NOT NULL , `itemAssignedUserID` INT NOT NULL , `itemCreateUserID` INT NOT NULL , `itemCreateDT` DATETIME NOT NULL , `itemUpdateUserID` INT NOT NULL , `itemState` CHAR(1) NOT NULL , PRIMARY KEY (`itemID`)) ENGINE = InnoDB;

Make user table

CREATE TABLE `tms`.`usertable` ( `userID` INT NOT NULL AUTO_INCREMENT , `userFirstName` TEXT NOT NULL , `userLastName` TEXT NOT NULL , `userEmail` TEXT NOT NULL , `userPassword` TEXT NOT NULL , `userStatus` CHAR(1) NOT NULL , PRIMARY KEY (`userID`)) ENGINE = InnoDB;

Adding foreign keys onto item table

ALTER TABLE `itemtable` ADD FOREIGN KEY (`itemAssignedUserID`) REFERENCES `usertable`(`userID`) ON DELETE RESTRICT ON UPDATE RESTRICT; ALTER TABLE `itemtable` ADD FOREIGN KEY (`itemCreateUserID`) REFERENCES `usertable`(`userID`) ON DELETE RESTRICT ON UPDATE RESTRICT; ALTER TABLE `itemtable` ADD FOREIGN KEY (`itemUpdateUserID`) REFERENCES `usertable`(`userID`) ON DELETE RESTRICT ON UPDATE RESTRICT;


#Run the code
