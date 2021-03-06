﻿using System;

namespace TowerDefense
{
    class Program
    {
        //TODO - update to use I/O
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[]{
                      new MapLocation(0, 2, map),
                      new MapLocation(1, 2, map),
                      new MapLocation(2, 2, map),
                      new MapLocation(3, 2, map),
                      new MapLocation(4, 2, map),
                      new MapLocation(5, 2, map),
                      new MapLocation(6, 2, map),
                      new MapLocation(7, 2, map)
                    }
                );

                IInvader[] invaders =
                {
                    new BasicInvader(path),
                    new FastInvader(path),
                    new ShieldedInvader(path),
                    new StrongInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] towers =
                {
                    new BasicTower(new MapLocation(1, 3, map )),
                    new PowerfulTower(new MapLocation(3, 3, map )),
                    new BasicTower(new MapLocation(5, 3, map ))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
                Console.ReadLine();
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefenseException");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}