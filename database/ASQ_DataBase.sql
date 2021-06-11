-- MySQL Script generated by MySQL Workbench
-- Fri Jun 11 19:18:56 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema asp
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema asp
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `asp` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `asp` ;

-- -----------------------------------------------------
-- Table `asp`.`admin`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asp`.`admin` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(30) NULL DEFAULT NULL,
  `password` VARCHAR(30) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `asp`.`subject`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asp`.`subject` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `subject_name` VARCHAR(30) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `asp`.`question`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asp`.`question` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_subject` INT NULL DEFAULT NULL,
  `question` VARCHAR(300) NULL DEFAULT NULL,
  `correct_answer` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `id_subject` (`id_subject` ASC) VISIBLE,
  CONSTRAINT `question_ibfk_1`
    FOREIGN KEY (`id_subject`)
    REFERENCES `asp`.`subject` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `asp`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asp`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_name` VARCHAR(30) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `asp`.`results`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asp`.`results` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NULL DEFAULT NULL,
  `question_id` INT NULL DEFAULT NULL,
  `user_answer` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `user_id` (`user_id` ASC) VISIBLE,
  INDEX `question_id` (`question_id` ASC) VISIBLE,
  CONSTRAINT `results_ibfk_1`
    FOREIGN KEY (`user_id`)
    REFERENCES `asp`.`users` (`id`),
  CONSTRAINT `results_ibfk_3`
    FOREIGN KEY (`question_id`)
    REFERENCES `asp`.`question` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
