﻿namespace AdventOfCSharp.Puzzles.Year23.Day16;

public partial class Puzzle
{
    public string PuzzleInput()
    {
        return """
            \./....\../......................|............../-.......|....................|....../|\..../.............\...
            ...........|.-.............|.././........../........................./...........||.....................-....\
            ...............\.............-...................-............/.|...|.......-...............................-.
            .......................................\..|-.../\....../.........|............/...|.....-.|...........\...|...
            ............/.-..|...\........|...........-......................\.........-........\....../....|.........|...
            ................-...........-|....\.................-........\........\...|.././......./......................
            ......................-....../.-........../........\....../..../.............-..........|.|.................|.
            ...|....................|.|../.......\.......|.......-...............|.......\......\....................|\...
            .........\.............|.......-.....................|....................|..................-.......\-...\...
            .../............-........../.||..../........-...../-.........-......./......\........|........................
            ....|..../.../../.....\..............-.-................../........|...../....\....\...................|......
            .......\..-..................|..../..........|....................-............/...................\|../......
            ..-.\................../................../....\........./...\.\/.............................\|..............
            .......-...............................-.......|....................|......................../...........|/...
            ................|...\-....-.......|/......./.......................|../.\-...-....../...\........\......\.|...
            .....................-.......-....-................|.............-........-....................\....../....-..
            \..|.|....-......../......../.../...................|.....................\..--...............-.......||......
            .....-.\.....................-...\............../....\.......-/../|...|......../..\..................../......
            ....|...\......................|...|.../...|...............\...........-........................|.......--.-..
            ......\....|.-...........\................................|.................\..............\..|...............
            ...................||..................\|...................|....\............-....../........\.../.....-...-.
            ....................................|....|......./.\..................../..............|../.............\.....
            ......|...\./......../......|....\..././.......|...............................-.........../.-..\.............
            .|.../....|.................-..............|..................\....../..........-..........|...|......|./.....
            .........|.........../..\...|....../...................................................-......................
            ../....|/.............|.........../....................\.......\............./.........../.......-.........\-.
            ................\....................\.....-..|............-......-|...............\......\...-...............
            ..........|..........|...........|.../.............................-......\.....|\.........\.\.............../
            .........................../...........\.............|................../.-.......-....././\.........-........
            \....\................../..../.............-../......|.\.........-./..\........./.............................
            .\..../..............|........../.......\........|.-.-........//\.......|.....-.../..-.....-...........-......
            .......|................\.....................\.............-........./..................-...-...........\....
            ....../.......-......././.-.....|..........|.........|..........\............................/................
            ................\......\................\\.\..\........\.................................\......-/.....-......
            ..-...../......-.......................................|.................|......-.-...-.....\....../...-......
            ........................\....|.....\....|............................\..............\.......................\.
            ............................/|...|........\.\....\......-|......................|.....|.\-...-......-.........
            \..|...........................\.................\.-................../................./..../.\..............
            |.../.............\...............................|..|..-......-.......-.......|..\../.........-...........|..
            ...........|................\............................../.......................|..../-|...................
            ...\.|.\..................|.\-/....../-/..|/............\......../\.\...........\\.......-....-\..............
            .................................-......./..-............|..\../..................................|/./|..../..
            .../..../........|-.........|.....|..............-.................../.....|-.......|.....|...............\...
            -..-...................//............................./.........-...............-.........|.../...........\...
            .............././\......|..............\..................|...............-............................-......
            /.........|/.....-../|......-.........|..-.-...........-........|..........-..................................
            .............\.......|/........../.....|.......-....-....../......-...................-....|........\.........
            \...|.|.../..|....../....-.........................-..............|.....\.......-........\........-....|......
            -.-..\..........|........................./..........|..-./...........................|...........-........-..
            ....\./..............-.........|......./.-..............-.-../\........|..|.........-..............\...\.../..
            ..|...........\...../......../.../.........\....../....-..................................|/............-...|.
            .../.........|..-................|..........|....\/..........|..|\.......|...........|........................
            ........../.............\...\.............................-...................|................-...-..........
            .....................-.................................../../.............................-../................
            .-........./......|........-...../...................\..|-........-...\..........././||.......................
            .........|../../.....-...........-....-..-...|.............................\..................................
            ...................-.....\......../............./...............-.......\.........../........|............../.
            .|\.............................................-.........-....|.....\..................-..-.......\..........
            /................/....\.........\|...............-.............|......./...........-.....\........-.......--..
            ..........-........\........\-...\....\\........../...|./.........................\.....|.................\../
            ............................-.|............................\...\../..........................\......./...../..
            .....//.......|..\.........-..\.........-....\..-..\.....-.....//.../.........................................
            ................................|....|..\............/|./.\....|.............-..\|................./..........
            .....|.......-.............-../...../.........|../.....................|........................./.....|......
            .-...\...../................\.-........|..|...|...|.........\|......|...../...../..........\................|.
            .../../............-.........|................\.....\....-...................../.../...........-...|...../|...
            ..-..........-.......-.............\..............-..............\.......|....................................
            ..|................/........................-...................../.................................|......../
            ...../........\......./....../......||.......|-...............-.....-............../../.......................
            ...\..../...................-........\.........\............................/....|.........-..........-.......
            .../................\....\..|-...........................\.-..-......|.|.-/.....-............./...............
            ../............\...........................-../....|....................-..............|........./......|...\\
            .........................\..................|..\........................./....................\...............
            /.............|.....................-.....\.....-..|............/..........|./...|....-...-....|-....../......
            .\.-.....\............././.........................\..........-......................|........\...............
            ........\../............../......\.....\..-............|............\............../..|.......................
            ....-../....\..................................-......../...|................................................-
            .......................\............-...................../.........\............-../.........\/..|../....-/|.
            ..../.............|....../............-.|......../.....................|...../..|.....-.............../.......
            ....................|\...........-...................................../.......................-...-..|..\.|/.
            ......................-....-\........../..............\.......-....\.....|...............\.........-..........
            .|......../.....|.........||.................../.....\...|.........\........../........\............../.......
            .-............/-..........-...........\..........\.......-....................................................
            .....|/....-.../......-......................../.|./...\.......\/......./......../..\...../...|...|.........\-
            .............../..\.../-......|\\......../............../............|/......................./.......\.......
            .....\.-./....../............/..-................../....\..................-.................|.......-/..-....
            .-................-..-...........................-..|............-.................../...........-...........|
            -......\......|......\............../.............../...-/.../....\.........................-.....|.....-.....
            .......\.....--.-............................\..........-./........||......|..\...../..../................|...
            .............-.....|..../.......|............|....................-......\.............../|...............|...
            ............|........../........|....................-....|....../.........\..........-........-..-...........
            ..............|.................-....|...........\.|.../.........../..........-......\|.............\..-......
            ......-............\.......\....................................................|\..\.......................-.
            ................||...........\...-\/..|..............\.........................../.......\.|.............|...|
            ....-...................-...../....|............\.../.........-..../....\........../..../.|..........\........
            ........-.....\........../....|.........\......./...........\.......-..|............../...........-..|........
            .................../.....-...........|....-...\......\...|...|...........................\.......||......\|...
            ......-.........|.....\....-..........|.......\....\..................................../........|...|./......
            ..................\.........../.............../.................../.........-.......-..../............/\.../..
            ........\...\...\....../.......\\........../............../.-.................../........|..............-.....
            ....../........................|................-.-......-....|......\\.-...-.|..........|..../...............
            /.......-.....|.....\...................|...../..............|......|.../....................\.....|..........
            |.\....-...............|/....|........../....................................\.-............................/.
            .......................-...............-.|...................|......\.....-\..|.......-......./\.....-......-.
            ................................|../.................................-........-...................|...........
            .....-.........\..-................./...........|...............|....................\/../../........|.-......
            ............................../......./.\/........./..|..............|.......................\................
            ......./.-.......\...........-...............|............|.............|..........|.|..........|.........--..
            ............-..............-.............\./...|.....|................|..........|/.............\.............
            .../....................-........-.................../.....\.............-...................\................
            """;
    }
}
