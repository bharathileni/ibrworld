CREATE DATABASE  IF NOT EXISTS forms;
USE forms;

DROP TABLE IF EXISTS user;
CREATE TABLE user(userId bigint(20) NOT NULL,encryptedPassword varchar(255) NOT NULL,emailId varchar(255) NOT NULL,PRIMARY KEY(userId));