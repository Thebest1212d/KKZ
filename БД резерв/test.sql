-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Час створення: Лис 12 2023 р., 17:27
-- Версія сервера: 10.4.28-MariaDB
-- Версія PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `test`
--

-- --------------------------------------------------------

--
-- Структура таблиці `clients`
--

CREATE TABLE `clients` (
  `Name` varchar(255) DEFAULT NULL,
  `Surname` varchar(255) DEFAULT NULL,
  `Telephone` varchar(255) DEFAULT NULL,
  `Mail` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `clients`
--

INSERT INTO `clients` (`Name`, `Surname`, `Telephone`, `Mail`) VALUES
('Bohdan', 'Brytiuk', '123', 'Brubog');

-- --------------------------------------------------------

--
-- Структура таблиці `employees`
--

CREATE TABLE `employees` (
  `CompanyName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(255) DEFAULT NULL,
  `WorkandServiceDescription` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `employees`
--

INSERT INTO `employees` (`CompanyName`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, `WorkandServiceDescription`) VALUES
('Lol', 'Bohdan', 'Brytiuk', 'Brubog12@gmail.com', '+380982023020', 'Бізнес'),
('Директор компанії', 'Богдан', 'Бритюк', 'Brubog12@gmail.com', '+380982023020', 'Я займаюся програмуванням, хотів би отримати посаду директора IT-компанії');

-- --------------------------------------------------------

--
-- Структура таблиці `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `order_name` varchar(255) DEFAULT NULL,
  `customer_name` varchar(255) DEFAULT NULL,
  `order_date` date DEFAULT NULL,
  `description` text DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `orders`
--

INSERT INTO `orders` (`order_id`, `order_name`, `customer_name`, `order_date`, `description`, `status`) VALUES
(1, 'Замовлення 1', 'Клієнт 1', '2023-10-01', 'Опис замовлення 1', 'Активний'),
(2, 'Замовлення 2', 'Клієнт 2', '2023-10-05', 'Опис замовлення 2', 'Активний'),
(3, 'Замовлення 3', 'Клієнт 1', '2023-10-10', 'Опис замовлення 3', 'Виконаний');

-- --------------------------------------------------------

--
-- Структура таблиці `repair_services`
--

CREATE TABLE `repair_services` (
  `service_id` int(11) NOT NULL,
  `service_name` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `duration` int(11) DEFAULT NULL,
  `materials` text DEFAULT NULL,
  `required_skills` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `repair_services`
--

INSERT INTO `repair_services` (`service_id`, `service_name`, `description`, `price`, `duration`, `materials`, `required_skills`) VALUES
(2, 'Профілактичне обслуговування', 'Проведення регулярного технічного обслуговування устаткування.', 120.00, 2, 'Необхідні інструменти та робочі матеріали', 'Технік'),
(3, 'Ремонт електричних схем', 'Діагностика та відновлення електричних схем устаткування.', 150.00, 3, 'Електричні компоненти, інструменти', 'Електротехнік'),
(4, 'Заміна ланцюга', 'Заміна витратних деталей в ланцюгу устаткування.', 60.00, 2, 'Необхідні деталі, інструменти', 'Технік'),
(5, 'Очищення фільтру', 'Проведення регулярного очищення фільтра в устаткуванні.', 30.00, 1, 'Очищувачі, інструменти', 'Технік'),
(6, 'Заміна трансмісії', 'Заміна трансмісії та редуктора устаткування.', 180.00, 4, 'Необхідні деталі, інструменти', 'Технік'),
(7, 'Ремонт гідравлічних систем', 'Діагностика та відновлення гідравлічних систем устаткування.', 200.00, 5, 'Гідравлічні компоненти, інструменти', 'Гідравлік'),
(8, 'Заміна мотора', 'Заміна обгортання мотора та електромагнітного стартера.', 120.00, 3, 'Мотори, інструменти', 'Електротехнік'),
(9, 'Ремонт конвеєра', 'Регулярний ремонт та обслуговування конвеєрів.', 90.00, 2, 'Запчастини, інструменти', 'Технік'),
(10, 'Заміна керуючих панелей', 'Заміна і ремонт керуючих панелей устаткування.', 140.00, 4, 'Електричні компоненти, інструменти', 'Електротехнік'),
(11, 'Оновлення програмного забезпечення', 'Оновлення програмного забезпечення устаткування.', 50.00, 1, 'Необхідні програмні засоби', 'Технік'),
(12, 'Заміна деталей', 'Заміна дефектних деталей в устаткуванні.', 75.00, 2, 'Необхідні деталі, інструменти', 'Технік');

-- --------------------------------------------------------

--
-- Структура таблиці `suppliers`
--

CREATE TABLE `suppliers` (
  `CompanyName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `ServicesAndEquipment` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `suppliers`
--

INSERT INTO `suppliers` (`CompanyName`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, `ServicesAndEquipment`) VALUES
('Microsoft', 'Bohdan', 'Brytiuk', 'Brubog12@gmail.com', '+380982023020', 'Ремонтне устаткування');

--
-- Індекси збережених таблиць
--

--
-- Індекси таблиці `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Індекси таблиці `repair_services`
--
ALTER TABLE `repair_services`
  ADD PRIMARY KEY (`service_id`);

--
-- Індекси таблиці `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`CompanyName`);

--
-- AUTO_INCREMENT для збережених таблиць
--

--
-- AUTO_INCREMENT для таблиці `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблиці `repair_services`
--
ALTER TABLE `repair_services`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
