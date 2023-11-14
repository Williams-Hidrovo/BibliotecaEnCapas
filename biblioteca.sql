-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-11-2023 a las 20:20:14
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `biblioteca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libro`
--

CREATE TABLE `libro` (
  `id` int(11) NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `autor` varchar(255) NOT NULL,
  `year` int(11) NOT NULL,
  `portada` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`id`, `titulo`, `autor`, `year`, `portada`) VALUES
(410, 'La maldición de Hill House', 'Shirley Jackson', 1959, 'https://imagessl5.casadellibro.com/a/l/s5/95/9788494836695.webp'),
(411, 'Volver a empezar', 'Colleen Hoover', 2023, 'https://imgv2-1-f.scribdassets.com/img/document/620319191/298x396/dd9915e551/1698876226?v=1'),
(412, 'Nosotros', 'Manuel Vilas', 2023, 'https://i.imgur.com/JnPQFnt.png'),
(413, 'En la sombra', 'Príncipe Harry', 2023, 'https://images.cdn1.buscalibre.com/fit-in/520x520/cf/3f/cf3fcc28092916d449265db681e6c7d9.jpg'),
(414, 'El Angel de la Ciudad', 'Eva Garcia', 2023, 'https://www.planetadelibros.com.ec/usuaris/libros/fotos/380/m_libros/379375_portada_el-angel-de-la-ciudad_eva-garcia-saenz-de-urturi_202310231105.jpg'),
(415, 'Hijos de la Fabula', 'Fernando Aramburu', 2023, 'https://www.planetadelibros.com.ec/usuaris/libros/fotos/380/m_libros/379371_portada_hijos-de-la-fabula_fernando-aramburu_202212231024.jpg'),
(416, 'Ceniza en la Boca', 'Brenda Navarro', 2022, 'https://m.media-amazon.com/images/I/41uLuAFanML.jpg'),
(417, 'La señora March', 'Virginia Feito', 2022, 'https://www.cervantesycia.com/images/noticias/054-es-club_senora-march.jpg'),
(418, 'La familia', 'Sara Mesa', 2022, 'https://cuadernoshispanoamericanos.com/wp-content/uploads/2022/11/biblioteca_1-1_DIC2022.jpg'),
(419, 'Tienes que mirar', 'Anna Starobinets', 2021, 'https://images.cdn1.buscalibre.com/fit-in/360x360/83/c7/83c72a374fa9d16994e5689e985713e8.jpg'),
(420, 'Tomas Nevinson', 'Javier Marias', 2021, 'https://cdn.penguin.co.uk/dam-assets/books/9780241568613/9780241568613-jacket-large.jpg'),
(421, 'Paradais', 'Fernando Melchor', 2021, 'https://i.imgur.com/9ZayxKr.jpg'),
(422, 'Miss Marte', 'Manuel Jabois', 2021, 'https://m.media-amazon.com/images/I/91FkQJlkAqL._AC_UF1000,1000_QL80_.jpg'),
(423, 'Simon', 'Miqui Otero', 2021, 'https://blackiebooks.org/wp-content/uploads/2020/07/Simon_3D_web.png');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE `prestamo` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_libro` int(11) NOT NULL,
  `fecha_retiro` date NOT NULL,
  `fecha_entrega` date NOT NULL,
  `entregado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `prestamo`
--

INSERT INTO `prestamo` (`id`, `id_usuario`, `id_libro`, `fecha_retiro`, `fecha_entrega`, `entregado`) VALUES
(64, 244, 410, '2023-11-09', '2023-11-16', 0),
(65, 244, 421, '2023-11-12', '2023-11-15', 0),
(66, 248, 417, '2023-11-01', '2023-11-08', 1),
(73, 247, 419, '2022-12-01', '2022-12-15', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `apellido`) VALUES
(244, 'Juan', 'Alcivar'),
(245, 'Ramon', 'Solana'),
(246, 'Hayden ', 'Mitchell '),
(247, 'Kiara ', 'Meyer'),
(248, 'Mckenna', 'Smith '),
(250, 'Maria', 'Palmer'),
(251, 'Pedro', 'Cevallos');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `libro`
--
ALTER TABLE `libro`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_libro` (`id_libro`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `libro`
--
ALTER TABLE `libro`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=425;

--
-- AUTO_INCREMENT de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=252;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD CONSTRAINT `prestamo_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`),
  ADD CONSTRAINT `prestamo_ibfk_2` FOREIGN KEY (`id_libro`) REFERENCES `libro` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
