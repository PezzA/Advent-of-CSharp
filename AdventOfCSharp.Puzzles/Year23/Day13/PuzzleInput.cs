﻿namespace AdventOfCSharp.Puzzles.Year23.Day13;

public partial class Puzzle
{
    public string PuzzleInput()
    {
        return """
            .#.####
            ##..#.#
            ##..#.#
            .#.####
            ..#..#.
            ####.#.
            #.#.#.#
            .#..#.#
            ##.##..
            #.#..#.
            #.#....
            
            .##.....#....#.
            .##.....#....#.
            ..#.#..##....##
            ...###...#..#..
            #..##.....##...
            .#.#...#.####.#
            #.#.....######.
            ##..###...##...
            #..#..##..##..#
            .##.#.#........
            #..#..##..##..#
            #####.#.##.###.
            .#....##.#..#.#
            ..##.#...#..#..
            #..####..#..#..
            
            .##......##
            .##......##
            .#.#.##.#.#
            #.########.
            #.##....##.
            #.######.#.
            ####....###
            ##.#.##.#.#
            ###......##
            ...######..
            ####.##.###
            
            ....#.###
            #.#..####
            ##.......
            ##.......
            #.#..####
            ....#.###
            #..##.#.#
            #.##...#.
            #.##..#.#
            ####..#..
            #.#.###.#
            #.#..##.#
            ####..#..
            #.##..#.#
            #.##...#.
            
            ##.####.#
            .###.####
            ###...###
            ###...###
            .###.####
            #..####.#
            ..###..#.
            ##..#..#.
            ####...#.
            #....#.#.
            ...#.....
            #....#.##
            #.#.#.##.
            #.#.#.##.
            #....#.##
            ...#.....
            #....#.#.
            
            .##..#..#..#..#
            #....##.##.##.#
            ......#..######
            ......#..######
            #....##.##.##.#
            .##..#..#..#..#
            ######..#.#.###
            .#..#.....#.#..
            #...#..#.#.##.#
            .###....#..###.
            .###....#..###.
            #...#..#.#.##.#
            .#..#.....#.#..
            ######..#.#.###
            .#...#..#..#..#
            
            .######.#.#..#.
            #..##....##..##
            #.#.#.###.#..#.
            #.#.#.###.#..#.
            #..##....##..##
            .######...#..#.
            #.#.#..#..####.
            #.#...#########
            .....###.##..##
            .#.#....###..##
            .#...#...#....#
            
            #.##.#......#.#
            #.##.#......#.#
            ..##.#.......#.
            .##.##.##.##...
            #.#.##...#.####
            ##...#.##.#.##.
            .#..#.##.#.#..#
            .#..#.##.#.#..#
            ##...#.##.#.##.
            #...##...#.####
            .##.##.##.##...
            ..##.#.......#.
            #.##.#......#.#
            
            ..#..#..#..#.
            ##.#.####.#.#
            ####......###
            #####.##.####
            ..#.#.##.#.#.
            ####..##..###
            ...#......#..
            ##.###..###..
            ...#..##..#..
            ##.##.##.##.#
            ##.###..###.#
            ####......###
            ..#.##..##.#.
            ##..........#
            ##.##....##.#
            
            .#.#....#.#......
            ...##..##.......#
            #..######..#.##..
            .###....###.##...
            .#.#.##.#.#..#...
            ..###..###.......
            ###..##..####.###
            #..##..##..##.#..
            ....#.##....#...#
            ###.#..#.###.#.#.
            #.#......#.##..#.
            #.#......#.##..#.
            ###.#..#.###.#.#.
            
            #.##..##...##..
            ##.#.#.####..##
            ##..#..#.#.##.#
            ##.###.##......
            ####...####..##
            ##.#.#.####..##
            ##.#.#.####..##
            ####...####..##
            ##.###.##......
            ##..#..#.#.##.#
            ##.#.#.####..##
            #.##..##...##..
            #...#.#########
            .##.###.#.#..#.
            ......####.####
            
            ##..##.
            .##....
            .##....
            ##..##.
            #.###.#
            #.##..#
            .######
            .######
            #.##..#
            #.###.#
            .#..##.
            
            ....#..
            ##.#.##
            ..#.#..
            ....###
            ##.#.##
            ##.####
            ###....
            ##.##..
            ....#..
            .....##
            #####..
            ##.....
            ....#.#
            ####.##
            ##..#..
            
            .#.##.#.....#.#.#
            ###..###.#####...
            ###..###.#####...
            .#.##.#.....#.#.#
            .#....#..#.###...
            #.#..#.#####..##.
            #.####.##......#.
            ##.##.##.##.##..#
            ###...##.##....##
            #.####.#####.####
            ##.##.##.##......
            #########.#.####.
            ###..####..###...
            
            #..####..#..#..##
            ###.##.####.#.##.
            ..######.....#.##
            ###.##.#####...#.
            #.#....#.#.#....#
            ##.####.###.#.#..
            ###....###.#.#.##
            ###.##.####.#####
            ...#..#....##...#
            ...#..#....##...#
            ###.##.####.#####
            ###....###.#.#.##
            ##.####.###.###..
            #.#....#.#.#....#
            ###.##.#####...#.
            
            ####..##.
            ####...##
            .....###.
            ...######
            ######...
            ....#....
            ####..#.#
            ####..#.#
            ....#....
            ######...
            ...####.#
            .....###.
            ####...##
            
            #...#..#.
            #...#..#.
            ####....#
            #..######
            ...######
            ###......
            ...##..##
            ###.####.
            #.#....#.
            
            .####..
            ##.#.#.
            ##.#.#.
            .####..
            #..#..#
            .....##
            .#.#..#
            ..#.#.#
            ..#.#.#
            .#.#..#
            .....##
            #..#..#
            .#.##..
            
            #.#.#....##..
            .####.#.####.
            .####.#..###.
            #.#.#....##..
            ..#...###....
            ..#...###....
            #.#.#....##..
            .####.#..###.
            .####.#.####.
            #.#.#....##..
            ##.#.####...#
            ..#..#..#.##.
            ##.#######..#
            .##..####...#
            ###..##....##
            .######.##...
            .#..#.##..##.
            
            ......#
            ##...#.
            .#....#
            .#....#
            .#...#.
            ......#
            #..###.
            ...#..#
            #.#..##
            #.#...#
            #..##.#
            #..##.#
            #.#...#
            #.#..##
            ...#..#
            #..###.
            ......#
            
            ##..#.#....
            ####..#.##.
            #.#.#..####
            ..#....#..#
            ..#....#..#
            #.#.#..####
            ####..#.##.
            ##..#.#....
            ####...###.
            #....######
            #...###...#
            ..#####..#.
            ..##.###.#.
            ..##.###.#.
            ..###.#..#.
            
            ..........#.###
            ..######...##.#
            .#......#......
            #.##..##.#.....
            ##.####.##.#.##
            #...##...###..#
            #...##...###..#
            ##.####.##.#.##
            #.##..##.#..#..
            
            ..#.......##.#.
            #.#.#...####..#
            .#..##.#.#.#.##
            .#..##.#.#.#.##
            #.#.#...####..#
            ..#.......##.#.
            ..#..#####....#
            .#.#.#......###
            .#.###......###
            
            ...#.##.#
            ....#..#.
            #..##..##
            ...######
            .#.#....#
            .#.#....#
            ...######
            #..##..##
            ....#..#.
            #..#.##.#
            ###..##..
            
            .#.####.#....
            #.#....#.#...
            ###....##.###
            #.##..##.#.##
            .#.#..#.#.###
            #.######.#...
            #.##..##.####
            
            ##.#.##
            #......
            #...#.#
            ####.##
            .#.#..#
            ...####
            ...####
            .#.#..#
            ####.##
            #...#.#
            #......
            ##.#.##
            .#..#..
            #..#..#
            #.....#
            
            #.########.#.
            ..##....##..#
            ..##....##..#
            #.########.#.
            .##..##..##.#
            #.##....##.#.
            .#.....#..#.#
            ...#.##.#....
            #..........#.
            .#...##...#..
            .##.#..#.##..
            
            .##..#..#.##.#.
            #..#.##...##...
            #######..####..
            #######..####..
            #..#.##...##...
            .##..#..#.##.#.
            .#.....#.#....#
            ......###.#..##
            .......#.###.#.
            ####.##..#..#.#
            ....#.#.##.#..#
            ######.######..
            ....#..##.###..
            
            ##.#....#..
            ##.#...##..
            .###.##.#.#
            ##.####....
            ...##....#.
            ..#....#.#.
            .....##..##
            .#..####...
            .#..####...
            .....##..##
            ..#....#.#.
            ...##....#.
            ##.####....
            .###.##.#.#
            ##.#...##..
            
            ##.####.#
            .#.####.#
            .#.####.#
            ##..##..#
            ####..###
            ##.####.#
            #.#....#.
            
            ...#..##.
            ......##.
            #...#####
            #..#.####
            ...######
            .#.######
            ##...#..#
            ###..####
            ##..#....
            
            ###..###.
            ####.#.#.
            ..#..##.#
            ###.#...#
            ......##.
            ..###.###
            ..#...###
            ##..#.#.#
            ##.......
            ..#......
            ######...
            #####...#
            ##..##.##
            ###....#.
            ###.#.###
            #####..##
            #####.###
            
            ..#..###...
            ..#...##...
            ##..###.##.
            #.#..###..#
            .####...##.
            #.###.#.###
            ..##.....##
            #.#..##.#.#
            ######.#.#.
            .####..#..#
            .##.##.....
            ..#......##
            ..#......##
            
            ..#...##...#..#
            ..####..####...
            .#.#.#..#.#.#..
            ###.#.##.#.###.
            ..##.####.##...
            #..###..###..#.
            #....####....#.
            ..#.######.#...
            ..#.######.#...
            #....####....#.
            #..###..###..#.
            ..##.####.##...
            ###.#.##.#.###.
            .#.#.#..#.#.#..
            ..####..####..#
            ..#...##...#..#
            ##.##.##.##.##.
            
            .###..#.#
            ..#...#.#
            ##.####..
            #..#.####
            ....##...
            ....##...
            #..#.####
            #..####..
            ..#...#.#
            .###..#.#
            .###..#.#
            
            #..##..##...##...
            ........#########
            ##....###########
            #.#..#.#.#.#..#.#
            .##..##..##....##
            ###..############
            #########...##...
            .#.##.#.#########
            ..#..#..###....##
            ###..#####.#..#.#
            .#.##.#..######.#
            ..#..#..#..#..#..
            ..####..##..##..#
            #.####.##########
            ##.##.##.#.####.#
            ..####..#..#..#..
            ########...####..
            
            ..#.#....#.#..##.
            ###.###.##.###..#
            ##.#......#.##..#
            #....####....#..#
            .##.#....#.##.##.
            .#....##....#.##.
            ....######.......
            #....#..#....#..#
            ##.#.#..#.#.#####
            #.#...##...#.####
            #.##.####.##.#..#
            #####.##.########
            .##..#..#..##.##.
            .###......###....
            #..#.#..#.#..#..#
            
            #.#.#.#.#.####.
            ...########..##
            ..#.###.###..##
            ..#.#.#.###..##
            #...#..#...##..
            .##..##########
            #..#.....##..##
            
            #.###..##.#......
            #.###..##.#......
            .#.#...#....#..#.
            #.#####..###.....
            #####......#.###.
            ....#.###.#...###
            ....##.#.#.##..#.
            #.##.#...#...##.#
            ..##..#.#########
            #.#..###.#..###.#
            #.#..###.#..#####
            ..##..#.#########
            #.##.#...#...##.#
            ....##.#.#.##..#.
            ....#.###.#...###
            #####......#.###.
            #.#####..###.....
            
            ......#
            ....#.#
            #..#.#.
            .#.####
            .#.####
            #..#.#.
            ....#.#
            ......#
            .####.#
            
            ....#.##.##..##..
            ####..#.##.#.##.#
            .#.....#.###....#
            ###.####.........
            #.##.#.#..###..##
            ##.#.####.#######
            ####.##.#....##..
            #######.#....##..
            ##.#.####.#######
            #.##.#.#..###..##
            ###.####.........
            
            ###..#...##...#..
            ..#.####.##.####.
            ##.#..#......#..#
            ..#..#........#..
            ###.#.########.#.
            ##.#...######...#
            ###.############.
            ##.#.#..####..#.#
            ##..#.#.####.#.#.
            ..#...#..##..#...
            ###.#####..#####.
            #.#.###.####.###.
            ##..###.####.###.
            
            ##.##.####..##.##
            ###..####..#..#..
            #.####.##..##.#..
            ..####..#..#...#.
            ##.##.##....#...#
            #.#..#.####.#.#..
            ............#...#
            #..##..#...#..##.
            #......#.##...##.
            .#.##.#.###.##..#
            ##.##.####.####.#
            ##.##.####.####.#
            .#.##.#.###.##..#
            #......#.##...##.
            #..##..#...##.##.
            ............#...#
            #.#..#.####.#.#..
            
            .##..###.####..#.
            .###...####.###..
            ##...#..##.#.###.
            ##.##.#.##.##.#.#
            ##.##...##.##.#.#
            #.##...#..##.##..
            .###....#####.#..
            ..####.#..#..###.
            ..####.#..#..###.
            .###....#####.#..
            #.##...#..##.##..
            ##.##...##.##.#.#
            ##.##.#.##.##.#.#
            
            ##.##..###.
            ##.##.#..#.
            ......#...#
            ......#...#
            ##.##.#..#.
            ##.##..###.
            ###....#.#.
            #.#..#..#..
            #.##...#.#.
            ..####.###.
            ..####.##..
            #.##...#.#.
            #.#..#..#..
            ###....#.#.
            ##.##..###.
            ##.##.#..#.
            ......#...#
            
            ###.############.
            ...#.#.######.#.#
            ##.......##......
            ##.....#....#....
            ####....####....#
            ..##.##.#..#.##.#
            ...######..######
            ####.##..##..##.#
            #...##..#..#..##.
            ..#.#.#..##..#.#.
            .....#.#....#.#..
            #####..#.##.#..##
            ...#..##....##..#
            ####...#.##.#...#
            ###.#..#....#..#.
            
            ....##..#.#..
            ....#...#####
            ....#...#.###
            .##..#...#...
            ....###.####.
            #..##.#.##...
            ####..#####..
            #####..#.##..
            ####...##....
            #####.#...###
            #..###.####..
            .##.####..###
            ####.###..###
            ....#...#....
            .##...#######
            
            ...######
            #.#..##..
            .#.######
            #...#####
            ..#######
            #####..##
            #.#.####.
            .#...##..
            .#..#..#.
            #...#..#.
            .###.##.#
            ..##.##.#
            ..##.##.#
            .###.##.#
            #...#..#.
            
            ##...#.
            ##...#.
            .######
            ###...#
            .#.#.#.
            ...#.#.
            #..#.##
            #..#.##
            ...#.#.
            .#.#.#.
            ##....#
            .######
            ##...#.
            
            ##..#..##
            ##.#.....
            ##...##..
            #.###....
            ###..#.##
            #####.###
            ##.####..
            #####.###
            ....#.###
            ..##...##
            ..####...
            ..###....
            ...######
            #######..
            ###..#...
            
            ####....#####
            #####...#.##.
            ......#.##..#
            ....####.####
            ....##...#..#
            #..#.#....#..
            .....#...#..#
            ########.....
            #######.#.##.
            #..##..#.#..#
            #..##.....##.
            .....##.#.##.
            .##.#.#.#.##.
            ########.####
            #..#...#..##.
            
            .#####.#.##
            .#####.#.##
            ...#......#
            .#.#..###.#
            ###.###.#.#
            ###..#...##
            ##.#####...
            ##..##..#.#
            ..##.####.#
            #.#.#..####
            #.#.#..####
            ..##.####.#
            ##..##..#.#
            ##.#####...
            ###..#...##
            ##..###.#.#
            .#.#..###.#
            
            ##......#####
            #..#..#..##.#
            #.#.##.#.####
            ##..##..##..#
            ..#....#...##
            ###########..
            ..######..##.
            #.....#..#..#
            .##....##..##
            ###.##.###...
            #........#..#
            ##..##..###..
            ##..##..###..
            
            #.#..#.#..#.#..
            #.##.#.#..#.#.#
            #.##.#.#..#.#.#
            #.#..#.#..#.#..
            ...#...#..#...#
            ...##..#..#..##
            ..#...#....#...
            .##.#.######.#.
            .....#......#..
            #######....####
            #.#.###.##.###.
            ##...#......#..
            #.##.#.####.#.#
            #.###..#..#..##
            ###..##....##..
            #.###..#..##.##
            #.#.....##.....
            
            ...#.#..#.#......
            ##..#....#..####.
            #####....########
            ##.#......#.####.
            #.#...##...#.##.#
            ##..........####.
            #.##########.##.#
            .#####..#.###..##
            .############..##
            
            ..#.##..#
            ..#.##..#
            .###..#..
            ##.#..##.
            #...#.#..
            ###.#..#.
            ##.#.####
            ..#...#..
            ##.#....#
            ..###.#..
            #.#.###.#
            .#.#####.
            ...#....#
            ...#....#
            .#.#####.
            #.#.###.#
            ..###.#.#
            
            ..#...#.#
            .#....#.#
            #..#####.
            ..#####..
            ...##...#
            #.##.....
            #.##.....
            ...##...#
            #.#####..
            #..#####.
            .#....#.#
            ..#...#.#
            .#..#.##.
            .#..#.##.
            ..#...#.#
            
            .#.####.##.####
            ##.....#..#####
            #.#.#......####
            ##.#.#.#..#####
            .#.########.##.
            #.....##....##.
            .#..#....##.##.
            #..#.#....##.##
            ##.###.####.##.
            ##.##....#.....
            #.##.##.####..#
            .##..###.#.....
            .##..###.#.....
            
            ......#..#.
            .......#..#
            .......#..#
            ......#....
            ######.####
            #.##.##....
            #######.##.
            ######.#..#
            ######..#..
            #########..
            ......####.
            #.##.###...
            ######.#.##
            ##..##.#...
            #######....
            ..##...####
            .......##..
            
            .##.#####..#.
            ##.#..#.#....
            .#.###.##.#.#
            ##.###.....#.
            ..#..#.###..#
            ##..#.#....##
            ##..#.#....##
            ..#..#.###..#
            ##.###.....#.
            .#.###.##.#.#
            ##.#..#.#....
            .##..####..#.
            .##..####..#.
            
            #...#..##.#.#..
            #.#..##.####.#.
            #.#..##.####.#.
            #...#..##.#.#..
            .#.#...#..###.#
            ......#.....###
            ....##..#.#####
            ##...####.#.##.
            #...#...##..###
            ...###.##..##.#
            ...##..##..##.#
            
            ###..####..
            ###..####..
            ##....#....
            .####.###..
            ###.###.#..
            ##.###..###
            ....#.#..##
            #.#..#..#..
            ..#...#####
            .#.####....
            ##......##.
            
            ##.##.#.#..
            ###.#..##..
            ..##.##.##.
            #.#..#.#.##
            #.###....#.
            #..#.#...##
            ...##.###.#
            ...##.###.#
            #..#.#....#
            #.###....#.
            #.#..#.#.##
            ..##.##.##.
            ###.#..##..
            ##.##.#.#..
            .###.#..##.
            #.####..#.#
            #.####..#.#
            
            ####....####...
            ...#....#...#..
            ..##....##.....
            ...##..##....##
            ....####....#..
            #...####...#...
            .#...##...#.###
            .#........#....
            .....##........
            #..........#...
            .#.#.##.#.#.###
            ##..#..#.###.##
            .##......##..##
            ###.#..#.###.##
            #...####...#...
            ..##....##..###
            #.#.####.#.#...
            
            ####..#..
            ....####.
            ......##.
            .##...###
            .##...###
            ......#..
            ....####.
            ####..#..
            .##.##.#.
            .##..#.#.
            #######.#
            ....###.#
            ######..#
            
            #.##.#..#..
            #.##.##.#..
            #.##.##.#..
            ..##....#..
            ..##...#.#.
            #....###.##
            ..##...##.#
            .#..#..##.#
            #.##.##...#
            
            .#.########.#..
            ####.......###.
            #.###.##.###.##
            ..#........#..#
            ...##....##....
            ###..#..#..###.
            ##.########.###
            ##.########.###
            ###..#..#..###.
            
            ...##.....#
            .##..##....
            ..####..##.
            #..##..#.##
            #..##..#.#.
            ###..####..
            .#..#.#.###
            .##..##.#.#
            ##....#####
            ..#..#....#
            ##....##..#
            .#.##.#.###
            ...##...##.
            ##....###..
            ##....###..
            ...##...##.
            .#.##.#.###
            
            #....######.#
            #.##.#..#.#.#
            .####.#...##.
            #######.##...
            ##..#####.#..
            ......###...#
            ......###...#
            ##..##.##.#..
            #######.##...
            .####.#...##.
            #.##.#..#.#.#
            #....######.#
            ..##..###.#..
            
            ..####...##..
            .##..##..##..
            #.#..#.#....#
            ##....##....#
            #.#..#.##..##
            #.####.#.##.#
            ##.##..#.##.#
            ########....#
            ...##...####.
            
            ##.....
            ..#.##.
            ###.###
            .#.####
            .###..#
            .###..#
            .#.####
            
            #....####.###
            #....####.###
            .#..#...##.##
            #.##.#...####
            .#..##..#....
            .#..#.#...#..
            .####...##...
            #.##.#.#.#.#.
            ..##...#####.
            ##..##.##.##.
            #....###.#..#
            .#..#.#..##.#
            .......#.#...
            .#..#.#.####.
            ......#..#...
            ##..##..##.#.
            .#..#..#.###.
            
            #.#######.#.#..
            ..#.#...#...#..
            #......#...#.##
            ##..##....###..
            .#.##.###.#####
            ###..#.#..##...
            ###..#.#...#...
            ##.#.##.##..###
            .####.##..#..#.
            ..#####...##.##
            ..#####...##.##
            .####.##..#..#.
            ##.#.##.##..###
            ###..#.#...#...
            ###..#.#..##...
            
            ##.##.##.###.#..#
            ##.###.#..##..##.
            .###..#.##..###.#
            #.#...##.#####..#
            ..#.#.....#..####
            #...#.#..####.##.
            #.#...####.#.####
            ..#.#.#..##.#.##.
            ....##..##..#####
            .#..##...#.###..#
            .##.#..#..#.##..#
            .##.#..#..#.##..#
            .#..##...#.###..#
            ....##..##..#####
            ..#.#.#..##.#.##.
            
            ####...
            #.#####
            ..#####
            ####...
            #....##
            .###.##
            .#..#..
            ###.###
            ##...##
            .###.##
            #.#####
            
            ..######...
            .#......#..
            #....#...#.
            ##......###
            .##....##.#
            ...####...#
            .#.#..#.#.#
            .#..##..#..
            #........#.
            #.#.##.#.##
            .#.####.#.#
            .#.#..#.#..
            .#.####.#..
            .#.####.#..
            .#.#..#.#..
            
            ##.#......#.##.
            ##.#......#.##.
            ####......#####
            ###..#..#..###.
            ...#......#...#
            #...#.##.#...#.
            ##....##....##.
            ##.###..###.##.
            .###......##..#
            ...########....
            ###.#....#.###.
            ..###....###..#
            #.#.#.##.#.#.#.
            
            .######.######.##
            .#.##.#...##...#.
            ##....####..####.
            .##..##........##
            #.#..#.#.####.#.#
            ##.##.###....###.
            .#....#.#....#.#.
            .#.##.#.#....#.#.
            ..#..#..######..#
            ########..##.####
            ...##............
            #.####.#......#.#
            ..#..#..######..#
            
            .#.##......
            ...##......
            ..#..##.#..
            ..#.#..###.
            ....#...#..
            #.#..##..##
            ...##.#.###
            ..#.###..#.
            ..#.###..#.
            ...##.#.###
            #.#..##..##
            ....#...#..
            ..#.#..###.
            
            #..#.####.#..##
            #..###..###..#.
            #.#.#.##.#.#.##
            ##..#.##.#..###
            .##.##..#..##..
            ..#..#..#..#...
            ##..#....#..###
            .##.#....#.##.#
            ...#..##..#...#
            ....#....#....#
            .....#..#......
            ..#.#....#.#...
            ..##......##...
            ..##......##...
            ..#.#....#.#...
            .....#..#......
            ....#....#....#
            
            .##..#.
            .##..#.
            #.#.###
            ..##...
            .#...#.
            #####..
            #.#.###
            #.#.###
            #####..
            .#...#.
            ...#...
            
            ###..#..###
            .....#...##
            ......#.#..
            ..#.#...#..
            ...###.####
            ##.##...##.
            ..###...###
            ##...#.#..#
            #.##.##..#.
            ..#...#.#..
            ...#.#..#..
            ...#.#..#..
            ..#...#.#..
            
            .....##..
            ....#..#.
            .....##..
            #..#.##.#
            ####....#
            .##......
            #..###.##
            
            .#..##.######
            #.#..##.#.##.
            #.#..##.#.##.
            .#..##.######
            .####..#.....
            .#.#.#.#.#..#
            ####...#...#.
            
            #..#...
            ...#...
            .###.#.
            ..#.##.
            ..#.#.#
            .##.##.
            .##.##.
            ..#.#.#
            ..#.##.
            .###.#.
            ...#...
            #..#...
            ...###.
            #....##
            .######
            
            .##...#.#
            ####....#
            ...####.#
            #..#.####
            .##.##.##
            #####.#.#
            ....#####
            .##.##.#.
            .##..##.#
            #..#.####
            .##...##.
            #..#..###
            #..#..###
            
            ..#...#
            ..#...#
            .######
            .##.#.#
            .#.#.#.
            #...##.
            ......#
            #...#.#
            #...#.#
            ......#
            #...##.
            .#.#.#.
            .##...#
            .######
            ..#...#
            
            ###.##.
            ..##...
            .#.#..#
            .#.#...
            ..##...
            ###.##.
            ###...#
            .#.....
            #...#.#
            ...##.#
            ...##.#
            #...#.#
            .#.....
            ###...#
            ###.##.
            
            ....#..#.
            ##.######
            ##.#....#
            ..###..##
            ..#..##.#
            .....##..
            ##.#.##.#
            ..##.##.#
            ###..##..
            
            ###..##.##.#.
            ###..##.##.##
            ######.#.#.##
            ####.#..#.#.#
            ...#.#.##.###
            ##..##.#.....
            ....##.#..##.
            ........#.#..
            ...#....#.##.
            ###.####.....
            ...##...#.###
            ####..#.###..
            ....#..#..##.
            ##.####...#.#
            ...#.......#.
            
            ..#.#..
            ..#####
            ..#####
            ..#.#..
            ##..#..
            ...#.##
            .######
            .###..#
            .####.#
            .######
            ...#.##
            
            .####..####.#..##
            ##..#..#..###.#..
            #...#..#...#.#.##
            .#.##..##.#.##..#
            #..#.##.#..#.....
            .#..#..#..#......
            .#.######.#..#...
            ##.##..##.##.#...
            .###....###.#####
            
            ..###..#.##..
            ..###..#.#...
            ...#.#..#####
            #####.###.#.#
            ...#.#..#.#.#
            #####..###.#.
            ##.....##.#..
            
            ....##.
            .#.####
            .######
            .#.#..#
            #.##..#
            ...####
            .######
            #...##.
            ##..##.
            #...##.
            #...##.
            .######
            ...####
            
            ##....##.
            ##...##..
            ##.####.#
            ..##..##.
            ..##..##.
            ##.##.#.#
            ##...##..
            ##....##.
            ....##.##
            ..#...###
            ...##.##.
            ...#...##
            #####..#.
            
            ##.#.#.
            #..#.#.
            ..#...#
            ##.#...
            ...#...
            .###...
            .#.###.
            .#..#..
            .#..#..
            .#.###.
            .###...
            ...#...
            ##.#...
            ..#...#
            #..#.#.
            
            .###....#
            #..##..##
            #.#######
            #.#......
            ##...##..
            ..##....#
            #....##..
            ###......
            #.#.####.
            ....####.
            #####..##
            .##......
            ..##....#
            ####.##.#
            .###.##.#
            
            .##.##.##..##.##.
            .##.#.########.#.
            .##.####.##.####.
            #..######..######
            .......##..##....
            ..#..##########..
            ....#.##.##.##.#.
            #..#.##.####.##.#
            ####..#......#..#
            
            #..####..##..
            .#..##..#..#.
            .#......#..#.
            ..##..##....#
            ...#..#......
            #..#..#..##..
            .#......#..#.
            #........##..
            ...####......
            .###..###..##
            ...#..#......
            #..####..##..
            ..#....#....#
            #........##.#
            .###..###..##
            
            #.#..##..#.#.....
            #.#..##..#.#.##..
            ...#.##.#...#..#.
            .#........####.##
            #.##.##.##.#...##
            ..#.####.#.....#.
            ####.##.######.##
            ###.#..#.###..###
            ..##.##.##...#..#
            ..##.##.##...#..#
            ###.#..#.###..###
            """;
    }
}
