/*
 Navicat Premium Data Transfer

 Source Server         : ACDataBase
 Source Server Type    : PostgreSQL
 Source Server Version : 90303
 Source Host           : localhost:5432
 Source Catalog        : Cinema
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90303
 File Encoding         : 65001

 Date: 26/11/2018 12:50:38
*/


-- ----------------------------
-- Sequence structure for AgeRestrictions_IDRestrictions_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."AgeRestrictions_IDRestrictions_seq";
CREATE SEQUENCE "public"."AgeRestrictions_IDRestrictions_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Country_IDCountry_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Country_IDCountry_seq";
CREATE SEQUENCE "public"."Country_IDCountry_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Genre_IDGenre_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Genre_IDGenre_seq";
CREATE SEQUENCE "public"."Genre_IDGenre_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Genre_NameGenre_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Genre_NameGenre_seq";
CREATE SEQUENCE "public"."Genre_NameGenre_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Hall_IDHall_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Hall_IDHall_seq";
CREATE SEQUENCE "public"."Hall_IDHall_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Movies_AgeRestrictions_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Movies_AgeRestrictions_seq";
CREATE SEQUENCE "public"."Movies_AgeRestrictions_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Movies_Country_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Movies_Country_seq";
CREATE SEQUENCE "public"."Movies_Country_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Movies_Genre_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Movies_Genre_seq";
CREATE SEQUENCE "public"."Movies_Genre_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Movies_IDMovie_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Movies_IDMovie_seq";
CREATE SEQUENCE "public"."Movies_IDMovie_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Tickets_IDTicket_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Tickets_IDTicket_seq";
CREATE SEQUENCE "public"."Tickets_IDTicket_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Tickets_Place_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Tickets_Place_seq";
CREATE SEQUENCE "public"."Tickets_Place_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Tickets_VisitorMovie_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Tickets_VisitorMovie_seq";
CREATE SEQUENCE "public"."Tickets_VisitorMovie_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for cinema_sequence
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."cinema_sequence";
CREATE SEQUENCE "public"."cinema_sequence" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for country_sequence
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."country_sequence";
CREATE SEQUENCE "public"."country_sequence" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for ticket_sequence
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ticket_sequence";
CREATE SEQUENCE "public"."ticket_sequence" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Table structure for AgeRestrictions
-- ----------------------------
DROP TABLE IF EXISTS "public"."AgeRestrictions";
CREATE TABLE "public"."AgeRestrictions" (
  "IDRestrictions" int4 NOT NULL,
  "IndexRestrictions" text COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of AgeRestrictions
-- ----------------------------
INSERT INTO "public"."AgeRestrictions" VALUES (1, '0+');
INSERT INTO "public"."AgeRestrictions" VALUES (2, '6+');
INSERT INTO "public"."AgeRestrictions" VALUES (3, '12+');
INSERT INTO "public"."AgeRestrictions" VALUES (4, '16+');
INSERT INTO "public"."AgeRestrictions" VALUES (5, '18+');

-- ----------------------------
-- Table structure for Country
-- ----------------------------
DROP TABLE IF EXISTS "public"."Country";
CREATE TABLE "public"."Country" (
  "IDCountry" int4 NOT NULL,
  "NameCountry" text COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of Country
-- ----------------------------
INSERT INTO "public"."Country" VALUES (1, 'Абхазия');
INSERT INTO "public"."Country" VALUES (2, 'Австралия');
INSERT INTO "public"."Country" VALUES (3, 'Австрия');
INSERT INTO "public"."Country" VALUES (4, 'Азербайджан');
INSERT INTO "public"."Country" VALUES (5, 'Албания');
INSERT INTO "public"."Country" VALUES (6, 'Алжир');
INSERT INTO "public"."Country" VALUES (7, 'Ам. Виргинские острова');
INSERT INTO "public"."Country" VALUES (8, 'Американское Самоа');
INSERT INTO "public"."Country" VALUES (9, 'Ангола');
INSERT INTO "public"."Country" VALUES (10, 'Андорра');
INSERT INTO "public"."Country" VALUES (11, 'Антигуа и Барбуда');
INSERT INTO "public"."Country" VALUES (12, 'Аргентина');
INSERT INTO "public"."Country" VALUES (13, 'Армения');
INSERT INTO "public"."Country" VALUES (14, 'Аруба');
INSERT INTO "public"."Country" VALUES (15, 'Афганистан');
INSERT INTO "public"."Country" VALUES (16, 'Багамы');
INSERT INTO "public"."Country" VALUES (17, 'Бангладеш');
INSERT INTO "public"."Country" VALUES (18, 'Барбадос');
INSERT INTO "public"."Country" VALUES (19, 'Бахрейн');
INSERT INTO "public"."Country" VALUES (20, 'Белиз');
INSERT INTO "public"."Country" VALUES (21, 'Белоруссия');
INSERT INTO "public"."Country" VALUES (22, 'Бельгия');
INSERT INTO "public"."Country" VALUES (23, 'Бенин');
INSERT INTO "public"."Country" VALUES (24, 'Бермудские Острова');
INSERT INTO "public"."Country" VALUES (25, 'Болгария');
INSERT INTO "public"."Country" VALUES (26, 'Боливия');
INSERT INTO "public"."Country" VALUES (27, 'Бонэйр');
INSERT INTO "public"."Country" VALUES (28, 'Босния и Герцеговина');
INSERT INTO "public"."Country" VALUES (29, 'Ботсвана');
INSERT INTO "public"."Country" VALUES (30, 'Бразилия');
INSERT INTO "public"."Country" VALUES (31, 'Бр. Виргинские острова');
INSERT INTO "public"."Country" VALUES (32, 'Бруней');
INSERT INTO "public"."Country" VALUES (33, 'Буркина-Фасо');
INSERT INTO "public"."Country" VALUES (34, 'Бурунди');
INSERT INTO "public"."Country" VALUES (35, 'Бутан');
INSERT INTO "public"."Country" VALUES (36, 'Вануату');
INSERT INTO "public"."Country" VALUES (37, 'Ватикан');
INSERT INTO "public"."Country" VALUES (38, 'Великобритания');
INSERT INTO "public"."Country" VALUES (39, 'Венесуэла');
INSERT INTO "public"."Country" VALUES (40, 'Восточный Тимор');
INSERT INTO "public"."Country" VALUES (41, 'Вьетнам');
INSERT INTO "public"."Country" VALUES (42, 'Габон');
INSERT INTO "public"."Country" VALUES (43, 'Гаити');
INSERT INTO "public"."Country" VALUES (44, 'Гайана');
INSERT INTO "public"."Country" VALUES (45, 'Гамбия');
INSERT INTO "public"."Country" VALUES (46, 'Гана');
INSERT INTO "public"."Country" VALUES (47, 'Гватемала');
INSERT INTO "public"."Country" VALUES (48, 'Гвинея');
INSERT INTO "public"."Country" VALUES (49, 'Гвинея-Бисау');
INSERT INTO "public"."Country" VALUES (50, 'Германия');
INSERT INTO "public"."Country" VALUES (51, 'Гондурас');
INSERT INTO "public"."Country" VALUES (52, 'Гонконг');
INSERT INTO "public"."Country" VALUES (53, 'Гренада');
INSERT INTO "public"."Country" VALUES (54, 'Греция');
INSERT INTO "public"."Country" VALUES (55, 'Грузия');
INSERT INTO "public"."Country" VALUES (56, 'Дания');
INSERT INTO "public"."Country" VALUES (57, 'Д.Р.Конго');
INSERT INTO "public"."Country" VALUES (58, 'Джерси');
INSERT INTO "public"."Country" VALUES (59, 'Джибути');
INSERT INTO "public"."Country" VALUES (60, 'Доминика');
INSERT INTO "public"."Country" VALUES (61, 'Доминикана');
INSERT INTO "public"."Country" VALUES (62, 'Египет');
INSERT INTO "public"."Country" VALUES (63, 'Замбия');
INSERT INTO "public"."Country" VALUES (64, 'Зимбабве');
INSERT INTO "public"."Country" VALUES (65, 'Израиль');
INSERT INTO "public"."Country" VALUES (66, 'Индия');
INSERT INTO "public"."Country" VALUES (67, 'Индонезия');
INSERT INTO "public"."Country" VALUES (68, 'Иордания');
INSERT INTO "public"."Country" VALUES (69, 'Ирак');
INSERT INTO "public"."Country" VALUES (70, 'Иран');
INSERT INTO "public"."Country" VALUES (71, 'Ирландия');
INSERT INTO "public"."Country" VALUES (72, 'Исландия');
INSERT INTO "public"."Country" VALUES (73, 'Испания');
INSERT INTO "public"."Country" VALUES (74, 'Италия');
INSERT INTO "public"."Country" VALUES (75, 'Йемен');
INSERT INTO "public"."Country" VALUES (76, 'Кабо-Верде');
INSERT INTO "public"."Country" VALUES (77, 'Казахстан');
INSERT INTO "public"."Country" VALUES (78, 'Камбоджа');
INSERT INTO "public"."Country" VALUES (79, 'Камерун');
INSERT INTO "public"."Country" VALUES (80, 'Канада');
INSERT INTO "public"."Country" VALUES (81, 'Катар');
INSERT INTO "public"."Country" VALUES (82, 'Кения');
INSERT INTO "public"."Country" VALUES (83, 'Кипр');
INSERT INTO "public"."Country" VALUES (84, 'Киргизия');
INSERT INTO "public"."Country" VALUES (85, 'Кирибати');
INSERT INTO "public"."Country" VALUES (86, 'Китай');
INSERT INTO "public"."Country" VALUES (87, 'Колумбия');
INSERT INTO "public"."Country" VALUES (88, 'Кокосовые Острова');
INSERT INTO "public"."Country" VALUES (89, 'Коморские Острова');
INSERT INTO "public"."Country" VALUES (90, 'Конго');
INSERT INTO "public"."Country" VALUES (91, 'КНДР');
INSERT INTO "public"."Country" VALUES (92, 'Корея');
INSERT INTO "public"."Country" VALUES (93, 'Коста-Рика');
INSERT INTO "public"."Country" VALUES (94, 'Кот-д''Ивуар');
INSERT INTO "public"."Country" VALUES (95, 'Куба');
INSERT INTO "public"."Country" VALUES (96, 'Кувейт');
INSERT INTO "public"."Country" VALUES (97, 'Кюрасао');
INSERT INTO "public"."Country" VALUES (98, 'Лаос');
INSERT INTO "public"."Country" VALUES (99, 'Латвия');
INSERT INTO "public"."Country" VALUES (100, 'Лесото');
INSERT INTO "public"."Country" VALUES (101, 'Либерия');
INSERT INTO "public"."Country" VALUES (102, 'Ливан');
INSERT INTO "public"."Country" VALUES (103, 'Ливия');
INSERT INTO "public"."Country" VALUES (104, 'Литва');
INSERT INTO "public"."Country" VALUES (105, 'Лихтенштейн');
INSERT INTO "public"."Country" VALUES (106, 'Люксембург');
INSERT INTO "public"."Country" VALUES (107, 'Маврикий');
INSERT INTO "public"."Country" VALUES (108, 'Мавритания');
INSERT INTO "public"."Country" VALUES (109, 'Мадагаскар');
INSERT INTO "public"."Country" VALUES (110, 'Македония');
INSERT INTO "public"."Country" VALUES (111, 'Малави');
INSERT INTO "public"."Country" VALUES (112, 'Малайзия');
INSERT INTO "public"."Country" VALUES (113, 'Мали');
INSERT INTO "public"."Country" VALUES (114, 'Мальта');
INSERT INTO "public"."Country" VALUES (115, 'Мальдивы');
INSERT INTO "public"."Country" VALUES (116, 'Марокко');
INSERT INTO "public"."Country" VALUES (117, 'Маршалловы Острова');
INSERT INTO "public"."Country" VALUES (118, 'Мексика');
INSERT INTO "public"."Country" VALUES (119, 'Мозамбик');
INSERT INTO "public"."Country" VALUES (120, 'Молдавия');
INSERT INTO "public"."Country" VALUES (121, 'Монако');
INSERT INTO "public"."Country" VALUES (122, 'Монголия');
INSERT INTO "public"."Country" VALUES (123, 'Мьянма');
INSERT INTO "public"."Country" VALUES (124, 'Намибия');
INSERT INTO "public"."Country" VALUES (125, 'Науру');
INSERT INTO "public"."Country" VALUES (126, 'Непал');
INSERT INTO "public"."Country" VALUES (127, 'Нигер');
INSERT INTO "public"."Country" VALUES (128, 'Нигерия');
INSERT INTO "public"."Country" VALUES (129, 'Нидерланды');
INSERT INTO "public"."Country" VALUES (130, 'Никарагуа');
INSERT INTO "public"."Country" VALUES (131, 'Новая Зеландия');
INSERT INTO "public"."Country" VALUES (132, 'Норвегия');
INSERT INTO "public"."Country" VALUES (133, 'ОАЭ');
INSERT INTO "public"."Country" VALUES (134, 'Оман');
INSERT INTO "public"."Country" VALUES (135, 'Острова Кука');
INSERT INTO "public"."Country" VALUES (136, 'Пакистан');
INSERT INTO "public"."Country" VALUES (137, 'Палау');
INSERT INTO "public"."Country" VALUES (138, 'Панама');
INSERT INTO "public"."Country" VALUES (139, 'Папуа-Новая Гвинея');
INSERT INTO "public"."Country" VALUES (140, 'Парагвай');
INSERT INTO "public"."Country" VALUES (141, 'Перу');
INSERT INTO "public"."Country" VALUES (142, 'Пуэрто-Рико');
INSERT INTO "public"."Country" VALUES (143, 'Польша');
INSERT INTO "public"."Country" VALUES (144, 'Португалия');
INSERT INTO "public"."Country" VALUES (145, 'Россия');
INSERT INTO "public"."Country" VALUES (146, 'Руанада');
INSERT INTO "public"."Country" VALUES (147, 'Румыния');
INSERT INTO "public"."Country" VALUES (148, 'Саба');
INSERT INTO "public"."Country" VALUES (149, 'Сальвадор');
INSERT INTO "public"."Country" VALUES (150, 'Самоа');
INSERT INTO "public"."Country" VALUES (151, 'Сан-Марино');
INSERT INTO "public"."Country" VALUES (152, 'Сан-Томе и Принсипи');
INSERT INTO "public"."Country" VALUES (153, 'Саудовская Аравия');
INSERT INTO "public"."Country" VALUES (154, 'Свазиленд');
INSERT INTO "public"."Country" VALUES (155, 'Сейшелы');
INSERT INTO "public"."Country" VALUES (156, 'Сенегал');
INSERT INTO "public"."Country" VALUES (157, 'Сент-Винсент и Гренадины');
INSERT INTO "public"."Country" VALUES (158, 'Сент-Китс и Невис');
INSERT INTO "public"."Country" VALUES (159, 'Сент-Люсия');
INSERT INTO "public"."Country" VALUES (160, 'Сен-Мартен');
INSERT INTO "public"."Country" VALUES (161, 'Сербия');
INSERT INTO "public"."Country" VALUES (162, 'Сингапур');
INSERT INTO "public"."Country" VALUES (163, 'Синт-Эстатиус');
INSERT INTO "public"."Country" VALUES (164, 'Сирия');
INSERT INTO "public"."Country" VALUES (165, 'Словакия');
INSERT INTO "public"."Country" VALUES (166, 'Словения');
INSERT INTO "public"."Country" VALUES (167, 'США');
INSERT INTO "public"."Country" VALUES (168, 'Соломоновы Острова');
INSERT INTO "public"."Country" VALUES (169, 'Сомали');
INSERT INTO "public"."Country" VALUES (170, 'Судан');
INSERT INTO "public"."Country" VALUES (171, 'Суринам');
INSERT INTO "public"."Country" VALUES (172, 'Сьерра-Леоне');
INSERT INTO "public"."Country" VALUES (173, 'Таджикистан');
INSERT INTO "public"."Country" VALUES (174, 'Таиланд');
INSERT INTO "public"."Country" VALUES (175, 'Танзания');
INSERT INTO "public"."Country" VALUES (176, 'Того');
INSERT INTO "public"."Country" VALUES (177, 'Токелау');
INSERT INTO "public"."Country" VALUES (178, 'Тонга');
INSERT INTO "public"."Country" VALUES (179, 'Тринидад и Тобаго');
INSERT INTO "public"."Country" VALUES (180, 'Тувалу');
INSERT INTO "public"."Country" VALUES (181, 'Тунис');
INSERT INTO "public"."Country" VALUES (182, 'Туркменистан');
INSERT INTO "public"."Country" VALUES (183, 'Турция');
INSERT INTO "public"."Country" VALUES (184, 'Уганда');
INSERT INTO "public"."Country" VALUES (185, 'Узбекистан');
INSERT INTO "public"."Country" VALUES (186, 'Украина');
INSERT INTO "public"."Country" VALUES (187, 'Уоллис и Футуна');
INSERT INTO "public"."Country" VALUES (188, 'Уругвай');
INSERT INTO "public"."Country" VALUES (189, 'Фарерские острова');
INSERT INTO "public"."Country" VALUES (190, 'Фед. Штаты Микронезии');
INSERT INTO "public"."Country" VALUES (191, 'Фиджи');
INSERT INTO "public"."Country" VALUES (192, 'Филиппины');
INSERT INTO "public"."Country" VALUES (193, 'Финляндия');
INSERT INTO "public"."Country" VALUES (194, 'Фолклендские острова');
INSERT INTO "public"."Country" VALUES (195, 'Франция');
INSERT INTO "public"."Country" VALUES (196, 'Французская Полинезия');
INSERT INTO "public"."Country" VALUES (197, 'Хорватия');
INSERT INTO "public"."Country" VALUES (198, 'ЦАР');
INSERT INTO "public"."Country" VALUES (199, 'Чад');
INSERT INTO "public"."Country" VALUES (200, 'Черногория');
INSERT INTO "public"."Country" VALUES (201, 'Чехия');
INSERT INTO "public"."Country" VALUES (202, 'Чили');
INSERT INTO "public"."Country" VALUES (203, 'Швейцария');
INSERT INTO "public"."Country" VALUES (204, 'Щвеция');
INSERT INTO "public"."Country" VALUES (205, 'Шри-Ланка');
INSERT INTO "public"."Country" VALUES (206, 'Эквадор');
INSERT INTO "public"."Country" VALUES (207, 'Экваториальная Гвинея');
INSERT INTO "public"."Country" VALUES (208, 'Эритрея');
INSERT INTO "public"."Country" VALUES (209, 'Эстония');
INSERT INTO "public"."Country" VALUES (210, 'Эфиопия');
INSERT INTO "public"."Country" VALUES (211, 'ЮАР');
INSERT INTO "public"."Country" VALUES (212, 'Южный Судан');
INSERT INTO "public"."Country" VALUES (213, 'Ямайка');
INSERT INTO "public"."Country" VALUES (214, 'Япония');

-- ----------------------------
-- Table structure for Genre
-- ----------------------------
DROP TABLE IF EXISTS "public"."Genre";
CREATE TABLE "public"."Genre" (
  "IDGenre" int4 NOT NULL,
  "NameGenre" text COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of Genre
-- ----------------------------
INSERT INTO "public"."Genre" VALUES (1, 'Боевик');
INSERT INTO "public"."Genre" VALUES (2, 'Вестерн');
INSERT INTO "public"."Genre" VALUES (3, 'Гангстерский фильм');
INSERT INTO "public"."Genre" VALUES (4, 'Детектив');
INSERT INTO "public"."Genre" VALUES (5, 'Драма');
INSERT INTO "public"."Genre" VALUES (6, 'Исторический фильм');
INSERT INTO "public"."Genre" VALUES (7, 'Комедия');
INSERT INTO "public"."Genre" VALUES (8, 'Мелодрамма');
INSERT INTO "public"."Genre" VALUES (9, 'Музыкальный фильм');
INSERT INTO "public"."Genre" VALUES (10, 'Нуар');
INSERT INTO "public"."Genre" VALUES (11, 'Политический фильм');
INSERT INTO "public"."Genre" VALUES (12, 'Приключенческий фильм');
INSERT INTO "public"."Genre" VALUES (13, 'Сказка');
INSERT INTO "public"."Genre" VALUES (14, 'Трагедия');
INSERT INTO "public"."Genre" VALUES (15, 'Трагикомедия');
INSERT INTO "public"."Genre" VALUES (16, 'Триллер');
INSERT INTO "public"."Genre" VALUES (17, 'Фантастический фильм');
INSERT INTO "public"."Genre" VALUES (18, 'Фильм ужасов');
INSERT INTO "public"."Genre" VALUES (19, 'Фильм-катастрофа ');

-- ----------------------------
-- Table structure for Hall
-- ----------------------------
DROP TABLE IF EXISTS "public"."Hall";
CREATE TABLE "public"."Hall" (
  "IDHall" int4 NOT NULL DEFAULT nextval('"Hall_IDHall_seq"'::regclass),
  "NameHall" text COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of Hall
-- ----------------------------
INSERT INTO "public"."Hall" VALUES (7, 'Зал №7');
INSERT INTO "public"."Hall" VALUES (6, 'Зал №6');
INSERT INTO "public"."Hall" VALUES (5, 'Зал №5');
INSERT INTO "public"."Hall" VALUES (4, 'Зал №4');
INSERT INTO "public"."Hall" VALUES (3, 'Зал №3');
INSERT INTO "public"."Hall" VALUES (2, 'Зал №2');
INSERT INTO "public"."Hall" VALUES (1, 'Зал №1');

-- ----------------------------
-- Table structure for Movies
-- ----------------------------
DROP TABLE IF EXISTS "public"."Movies";
CREATE TABLE "public"."Movies" (
  "Genre" int4 NOT NULL,
  "Country" int4 NOT NULL,
  "Duration" int4 NOT NULL,
  "AgeRestrictions" int4 NOT NULL,
  "IDMovie" int4 NOT NULL,
  "NameMovie" text COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of Movies
-- ----------------------------
INSERT INTO "public"."Movies" VALUES (16, 145, 106, 4, 19, 'Гоголь');
INSERT INTO "public"."Movies" VALUES (17, 167, 110, 4, 20, 'Доктор Стрэндж');
INSERT INTO "public"."Movies" VALUES (16, 167, 141, 4, 21, 'Миссия невыполнима: Последствия');
INSERT INTO "public"."Movies" VALUES (16, 145, 137, 2, 22, 'Экипаж');
INSERT INTO "public"."Movies" VALUES (7, 195, 111, 4, 23, '1+1');
INSERT INTO "public"."Movies" VALUES (6, 145, 128, 2, 24, 'Движение вверх');
INSERT INTO "public"."Movies" VALUES (6, 145, 130, 3, 25, 'Сталинград');
INSERT INTO "public"."Movies" VALUES (6, 145, 120, 3, 26, '28 панфиловцев');
INSERT INTO "public"."Movies" VALUES (6, 167, 118, 4, 27, 'Риддик ');
INSERT INTO "public"."Movies" VALUES (1, 145, 95, 4, 28, 'Брат ');
INSERT INTO "public"."Movies" VALUES (6, 167, 102, 3, 29, 'Пеле: Рождение легенды');
INSERT INTO "public"."Movies" VALUES (17, 145, 117, 3, 30, 'Притяжение');
INSERT INTO "public"."Movies" VALUES (17, 167, 101, 2, 31, 'Черепашки ниндзя');
INSERT INTO "public"."Movies" VALUES (6, 2, 133, 4, 32, 'По соображениям совести');
INSERT INTO "public"."Movies" VALUES (1, 167, 90, 4, 34, 'Ниндзя 2');

-- ----------------------------
-- Table structure for Place
-- ----------------------------
DROP TABLE IF EXISTS "public"."Place";
CREATE TABLE "public"."Place" (
  "Row" int4 NOT NULL,
  "Place" int4 NOT NULL
)
;

-- ----------------------------
-- Records of Place
-- ----------------------------
INSERT INTO "public"."Place" VALUES (1, 1);
INSERT INTO "public"."Place" VALUES (1, 2);
INSERT INTO "public"."Place" VALUES (1, 3);
INSERT INTO "public"."Place" VALUES (1, 4);
INSERT INTO "public"."Place" VALUES (1, 5);
INSERT INTO "public"."Place" VALUES (1, 6);
INSERT INTO "public"."Place" VALUES (1, 7);
INSERT INTO "public"."Place" VALUES (1, 8);
INSERT INTO "public"."Place" VALUES (1, 9);
INSERT INTO "public"."Place" VALUES (1, 10);
INSERT INTO "public"."Place" VALUES (1, 11);
INSERT INTO "public"."Place" VALUES (1, 12);
INSERT INTO "public"."Place" VALUES (2, 13);
INSERT INTO "public"."Place" VALUES (2, 14);
INSERT INTO "public"."Place" VALUES (2, 15);
INSERT INTO "public"."Place" VALUES (2, 16);
INSERT INTO "public"."Place" VALUES (2, 17);
INSERT INTO "public"."Place" VALUES (2, 18);
INSERT INTO "public"."Place" VALUES (2, 19);
INSERT INTO "public"."Place" VALUES (2, 20);
INSERT INTO "public"."Place" VALUES (2, 21);
INSERT INTO "public"."Place" VALUES (2, 22);
INSERT INTO "public"."Place" VALUES (2, 23);
INSERT INTO "public"."Place" VALUES (2, 24);
INSERT INTO "public"."Place" VALUES (3, 25);
INSERT INTO "public"."Place" VALUES (3, 26);
INSERT INTO "public"."Place" VALUES (3, 27);
INSERT INTO "public"."Place" VALUES (3, 28);
INSERT INTO "public"."Place" VALUES (3, 29);
INSERT INTO "public"."Place" VALUES (3, 30);
INSERT INTO "public"."Place" VALUES (3, 31);
INSERT INTO "public"."Place" VALUES (3, 32);
INSERT INTO "public"."Place" VALUES (3, 33);
INSERT INTO "public"."Place" VALUES (3, 34);
INSERT INTO "public"."Place" VALUES (3, 35);
INSERT INTO "public"."Place" VALUES (4, 48);
INSERT INTO "public"."Place" VALUES (4, 36);
INSERT INTO "public"."Place" VALUES (4, 37);
INSERT INTO "public"."Place" VALUES (4, 38);
INSERT INTO "public"."Place" VALUES (4, 39);
INSERT INTO "public"."Place" VALUES (4, 40);
INSERT INTO "public"."Place" VALUES (4, 41);
INSERT INTO "public"."Place" VALUES (4, 42);
INSERT INTO "public"."Place" VALUES (4, 43);
INSERT INTO "public"."Place" VALUES (4, 44);
INSERT INTO "public"."Place" VALUES (4, 45);
INSERT INTO "public"."Place" VALUES (4, 46);
INSERT INTO "public"."Place" VALUES (4, 47);
INSERT INTO "public"."Place" VALUES (5, 49);
INSERT INTO "public"."Place" VALUES (5, 50);
INSERT INTO "public"."Place" VALUES (5, 51);
INSERT INTO "public"."Place" VALUES (5, 52);
INSERT INTO "public"."Place" VALUES (5, 53);
INSERT INTO "public"."Place" VALUES (5, 54);
INSERT INTO "public"."Place" VALUES (5, 55);
INSERT INTO "public"."Place" VALUES (5, 56);
INSERT INTO "public"."Place" VALUES (5, 57);
INSERT INTO "public"."Place" VALUES (5, 58);
INSERT INTO "public"."Place" VALUES (5, 59);
INSERT INTO "public"."Place" VALUES (5, 60);
INSERT INTO "public"."Place" VALUES (6, 61);
INSERT INTO "public"."Place" VALUES (6, 62);
INSERT INTO "public"."Place" VALUES (6, 63);
INSERT INTO "public"."Place" VALUES (6, 64);
INSERT INTO "public"."Place" VALUES (6, 65);
INSERT INTO "public"."Place" VALUES (6, 66);
INSERT INTO "public"."Place" VALUES (6, 67);
INSERT INTO "public"."Place" VALUES (6, 68);
INSERT INTO "public"."Place" VALUES (6, 69);
INSERT INTO "public"."Place" VALUES (6, 70);
INSERT INTO "public"."Place" VALUES (6, 71);
INSERT INTO "public"."Place" VALUES (6, 72);
INSERT INTO "public"."Place" VALUES (7, 73);
INSERT INTO "public"."Place" VALUES (7, 74);
INSERT INTO "public"."Place" VALUES (7, 75);
INSERT INTO "public"."Place" VALUES (7, 76);
INSERT INTO "public"."Place" VALUES (7, 77);
INSERT INTO "public"."Place" VALUES (7, 78);
INSERT INTO "public"."Place" VALUES (7, 79);
INSERT INTO "public"."Place" VALUES (7, 80);
INSERT INTO "public"."Place" VALUES (7, 81);
INSERT INTO "public"."Place" VALUES (7, 82);
INSERT INTO "public"."Place" VALUES (7, 83);
INSERT INTO "public"."Place" VALUES (7, 84);

-- ----------------------------
-- Table structure for Session
-- ----------------------------
DROP TABLE IF EXISTS "public"."Session";
CREATE TABLE "public"."Session" (
  "UsingHall" int4 NOT NULL,
  "WhatMovie" int4 NOT NULL,
  "PriceMovie" int4 NOT NULL,
  "Date" date NOT NULL
)
;

-- ----------------------------
-- Records of Session
-- ----------------------------
INSERT INTO "public"."Session" VALUES (3, 19, 300, '2018-11-30');
INSERT INTO "public"."Session" VALUES (2, 20, 350, '2018-11-25');
INSERT INTO "public"."Session" VALUES (6, 21, 300, '2018-11-28');
INSERT INTO "public"."Session" VALUES (6, 22, 300, '2018-11-28');
INSERT INTO "public"."Session" VALUES (1, 23, 250, '2018-11-26');
INSERT INTO "public"."Session" VALUES (3, 24, 300, '2018-11-28');
INSERT INTO "public"."Session" VALUES (1, 25, 300, '2018-11-25');
INSERT INTO "public"."Session" VALUES (2, 26, 350, '2018-11-25');
INSERT INTO "public"."Session" VALUES (5, 27, 350, '2018-11-27');
INSERT INTO "public"."Session" VALUES (6, 28, 250, '2018-11-29');
INSERT INTO "public"."Session" VALUES (3, 29, 300, '2018-11-28');
INSERT INTO "public"."Session" VALUES (7, 30, 400, '2018-11-29');
INSERT INTO "public"."Session" VALUES (6, 31, 350, '2018-11-25');
INSERT INTO "public"."Session" VALUES (6, 32, 400, '2018-11-25');
INSERT INTO "public"."Session" VALUES (3, 34, 400, '2018-11-26');

-- ----------------------------
-- Table structure for Tickets
-- ----------------------------
DROP TABLE IF EXISTS "public"."Tickets";
CREATE TABLE "public"."Tickets" (
  "IDTicket" int4 NOT NULL,
  "NameVisitor" text COLLATE "pg_catalog"."default" NOT NULL,
  "Place" int4 NOT NULL,
  "Price" int4 NOT NULL,
  "VisitorMovie" int4 NOT NULL,
  "Hall" int4 NOT NULL,
  "DateSession" date NOT NULL
)
;

-- ----------------------------
-- Records of Tickets
-- ----------------------------
INSERT INTO "public"."Tickets" VALUES (23, 'Романов Егор', 41, 300, 21, 6, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (25, 'Ермаков Данила', 64, 300, 22, 6, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (26, 'Колесникова Олеся', 28, 400, 30, 7, '2018-11-29');
INSERT INTO "public"."Tickets" VALUES (27, 'Карпова Варвара', 28, 250, 28, 6, '2018-11-29');
INSERT INTO "public"."Tickets" VALUES (28, 'Тимошенко Ярослава', 64, 350, 31, 6, '2018-11-25');
INSERT INTO "public"."Tickets" VALUES (29, 'Семик Вячеслав', 41, 300, 29, 3, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (30, 'Слипченко Дарья', 39, 300, 29, 3, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (31, 'Самойлов Сергей', 53, 350, 31, 6, '2018-11-25');
INSERT INTO "public"."Tickets" VALUES (32, 'Мавроди Илья', 29, 300, 29, 3, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (20, 'Семик Александр', 41, 29, 29, 3, '2018-11-28');
INSERT INTO "public"."Tickets" VALUES (21, 'Казаков Василий', 2, 19, 19, 3, '2018-11-30');
INSERT INTO "public"."Tickets" VALUES (22, 'Гогинов Андрей', 40, 20, 20, 2, '2018-11-25');

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."AgeRestrictions_IDRestrictions_seq"
OWNED BY "public"."AgeRestrictions"."IDRestrictions";
SELECT setval('"public"."AgeRestrictions_IDRestrictions_seq"', 2, false);
ALTER SEQUENCE "public"."Country_IDCountry_seq"
OWNED BY "public"."Country"."IDCountry";
SELECT setval('"public"."Country_IDCountry_seq"', 2, false);
ALTER SEQUENCE "public"."Genre_IDGenre_seq"
OWNED BY "public"."Genre"."IDGenre";
SELECT setval('"public"."Genre_IDGenre_seq"', 2, false);
ALTER SEQUENCE "public"."Genre_NameGenre_seq"
OWNED BY "public"."Genre"."NameGenre";
SELECT setval('"public"."Genre_NameGenre_seq"', 2, false);
ALTER SEQUENCE "public"."Hall_IDHall_seq"
OWNED BY "public"."Hall"."IDHall";
SELECT setval('"public"."Hall_IDHall_seq"', 2, false);
ALTER SEQUENCE "public"."Movies_AgeRestrictions_seq"
OWNED BY "public"."Movies"."AgeRestrictions";
SELECT setval('"public"."Movies_AgeRestrictions_seq"', 2, false);
ALTER SEQUENCE "public"."Movies_Country_seq"
OWNED BY "public"."Movies"."Country";
SELECT setval('"public"."Movies_Country_seq"', 2, false);
ALTER SEQUENCE "public"."Movies_Genre_seq"
OWNED BY "public"."Movies"."Genre";
SELECT setval('"public"."Movies_Genre_seq"', 2, false);
ALTER SEQUENCE "public"."Movies_IDMovie_seq"
OWNED BY "public"."Movies"."IDMovie";
SELECT setval('"public"."Movies_IDMovie_seq"', 2, false);
ALTER SEQUENCE "public"."Tickets_IDTicket_seq"
OWNED BY "public"."Tickets"."IDTicket";
SELECT setval('"public"."Tickets_IDTicket_seq"', 2, false);
ALTER SEQUENCE "public"."Tickets_Place_seq"
OWNED BY "public"."Tickets"."Place";
SELECT setval('"public"."Tickets_Place_seq"', 2, false);
ALTER SEQUENCE "public"."Tickets_VisitorMovie_seq"
OWNED BY "public"."Tickets"."VisitorMovie";
SELECT setval('"public"."Tickets_VisitorMovie_seq"', 2, false);
SELECT setval('"public"."cinema_sequence"', 35, true);
SELECT setval('"public"."country_sequence"', 215, true);
SELECT setval('"public"."ticket_sequence"', 33, true);

-- ----------------------------
-- Primary Key structure for table AgeRestrictions
-- ----------------------------
ALTER TABLE "public"."AgeRestrictions" ADD CONSTRAINT "AgeRestrictions_pkey" PRIMARY KEY ("IDRestrictions");

-- ----------------------------
-- Primary Key structure for table Country
-- ----------------------------
ALTER TABLE "public"."Country" ADD CONSTRAINT "Country_pkey" PRIMARY KEY ("IDCountry");

-- ----------------------------
-- Primary Key structure for table Genre
-- ----------------------------
ALTER TABLE "public"."Genre" ADD CONSTRAINT "Genre_pkey" PRIMARY KEY ("IDGenre");

-- ----------------------------
-- Primary Key structure for table Hall
-- ----------------------------
ALTER TABLE "public"."Hall" ADD CONSTRAINT "Hall_pkey" PRIMARY KEY ("IDHall");

-- ----------------------------
-- Primary Key structure for table Movies
-- ----------------------------
ALTER TABLE "public"."Movies" ADD CONSTRAINT "Movies_pkey" PRIMARY KEY ("IDMovie");

-- ----------------------------
-- Primary Key structure for table Place
-- ----------------------------
ALTER TABLE "public"."Place" ADD CONSTRAINT "Place_pkey" PRIMARY KEY ("Place");

-- ----------------------------
-- Primary Key structure for table Tickets
-- ----------------------------
ALTER TABLE "public"."Tickets" ADD CONSTRAINT "Tickets_pkey" PRIMARY KEY ("IDTicket");

-- ----------------------------
-- Foreign Keys structure for table Movies
-- ----------------------------
ALTER TABLE "public"."Movies" ADD CONSTRAINT "fk_Movies_AgeRestrictions_1" FOREIGN KEY ("AgeRestrictions") REFERENCES "AgeRestrictions" ("IDRestrictions") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Movies" ADD CONSTRAINT "fk_Movies_Country_1" FOREIGN KEY ("Country") REFERENCES "Country" ("IDCountry") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Movies" ADD CONSTRAINT "fk_Movies_Genre_1" FOREIGN KEY ("Genre") REFERENCES "Genre" ("IDGenre") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Session
-- ----------------------------
ALTER TABLE "public"."Session" ADD CONSTRAINT "fk_Session_Hall_1" FOREIGN KEY ("UsingHall") REFERENCES "Hall" ("IDHall") ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE "public"."Session" ADD CONSTRAINT "fk_Session_Movies_1" FOREIGN KEY ("WhatMovie") REFERENCES "Movies" ("IDMovie") ON DELETE CASCADE ON UPDATE CASCADE;

-- ----------------------------
-- Foreign Keys structure for table Tickets
-- ----------------------------
ALTER TABLE "public"."Tickets" ADD CONSTRAINT "fk_Tickets_Hall_1" FOREIGN KEY ("Hall") REFERENCES "Hall" ("IDHall") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Tickets" ADD CONSTRAINT "fk_Tickets_Movies_1" FOREIGN KEY ("VisitorMovie") REFERENCES "Movies" ("IDMovie") ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE "public"."Tickets" ADD CONSTRAINT "fk_Tickets_Place_1" FOREIGN KEY ("Place") REFERENCES "Place" ("Place") ON DELETE NO ACTION ON UPDATE NO ACTION;
