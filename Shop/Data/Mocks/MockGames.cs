﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockGames : iAllGames
    {
        private readonly iGameCategory _categoryGames = new MockCategory();
        public IEnumerable<Game> Games
        { get
            {
                return new List<Game>
                {
                    new Game
                    {   gamename = "Counter-Strike: Global Offensive",
                        shortdesc = "Шутер від першої особи,",
                        longdesc = "У грі є дві команди, терористи та спецвійська (контртерористи), одна проти одної в різних " +
                        "режимах гри на основі цілей. Найпоширеніші режими гри включають те, що терористи закладають бомбу, тоді як " +
                        "контртерористи намагаються їх деактивувати, або контртерористи намагаються врятувати заручників, захоплених " +
                        "терористами. Існує дев'ять офіційних режимів гри, кожен з яких має відмінні характеристики, характерні для " +
                        "цього режиму. У грі також є підтримка підбору партнерів, яка дозволяє гравцям грати на виділених серверах " +
                        "Valve, на додаток до серверів, розміщених у спільноті, із користувацькими картами та режимами гри",
                        img = "/img/cs_go.png",
                        price = 500,
                        isFavorite = true,
                        available = true,
                        Category =_categoryGames.AllCategories.ElementAt(2) },
                     new Game
                    {   gamename = "7 Days to Die",
                        shortdesc = "Гра в жанрі survival horror та симулятора виживання з відкритим світом ",
                        longdesc = "Дії 7 Days to Die відбуваєюься в процедурно генерованому світі, що повністю руйнується (крім торгових " +
                        "зон і найнижчого, не руйнівного блоку), охопленому зомбі-апокаліпсисом. Щоб зберегти життя свого персонажа, гравець " +
                        "повинен захищатися від ворожих зомбі, збирати різні ресурси та будувати будівлі.",
                        img = "/img/7_days_to_die.jpg",
                        price = 850,
                        isFavorite = false,
                        available = true,
                        Category =_categoryGames.AllCategories.First() },
                       new Game
                    {   gamename = "Minecraft",
                        shortdesc = "Пісочниця у відкритому світі з виглядом від першої/третьої особи",
                        longdesc = "Minecraft дає в розпорядження гравцеві тривимірний процедурно генерований світ, що складається з кубічних " +
                        "блоків, які можливо використовувати на свій розсуд. Блоки поділяються на матеріали та об'єкти, котрі не обов'язково " +
                        "мають видиму кубічну форму, але займають умовний один кубик. Гра не ставить перед гравцем однозначних цілей, але " +
                        "пропонує безліч можливостей і занять: досліджувати світ, створювати різноманітні споруди й предмети, битися з різними " +
                        "супротивниками. Можлива як одноосібна гра, так і багатокористувацька, коли багато гравців взаємодіють в межах одного світу.",
                        img = "/img/minecraft.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category =_categoryGames.AllCategories.Last() },
                        new Game
                    {   gamename = "FIFA 2021",
                        shortdesc = "Футбльний симулятор",
                        longdesc = "У режимі FIFA 21 Ultimate Team мета - зробити найкращу команду, купуючи гравців на трансферному ринку, а " +
                        "також отримувати їх із наборів та завдань. У режимі є шість видів ігор: Squad Battles (ігри з комп'ютером, але при цьому " +
                        "з командами, які створили інші гравці), Division Rivals (гра онлайн у спеціальній лізі), Випробування підбору команди (єдиний" +
                        " режим, в якому потрібно не грати, а збирати склад для отримання наборів та гравців), Товариські матчі з комп'ютером, по мережі " +
                        "та з друзями (кооп-режим), Драфт (збирати команду з гравців на вибір та грати з комп'ютером до чотирьох перемог, після цього " +
                        "отримуючи нагороди) та драфт онлайн ( те саме, тільки онлайн). ",
                        img = "/img/FIFA21.jpg",
                        price = 900,
                        isFavorite = false,
                        available = false,
                        Category =_categoryGames.AllCategories.ElementAt(3) }
                };
            }

        }
        public IEnumerable<Game> getFavGames { get ; set ; }

        public Game getObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}