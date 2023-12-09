namespace AdventOfCSharp.Puzzles.Year23.Day09;

public partial class Puzzle
{
    public string PuzzleInput()
    {
        return """
            12 15 18 21 24 27 30 33 36 39 42 45 48 51 54 57 60 63 66 69 72
            16 31 50 76 128 260 603 1440 3332 7343 15476 31542 62852 123360 239205 458014 863848 1600311 2905110 5160264 8963224
            1 7 22 48 87 141 212 302 413 547 706 892 1107 1353 1632 1946 2297 2687 3118 3592 4111
            12 23 36 62 124 254 502 969 1869 3621 6982 13270 24809 45876 84666 157141 294122 553651 1041528 1944054 3578426
            9 23 48 101 209 416 802 1529 2935 5694 11042 21037 38795 68675 116571 190984 306728 495653 834081 1507811 2959064
            8 1 -4 3 48 184 511 1225 2735 5912 12561 26229 53466 105620 201137 368104 646350 1087719 1752038 2694683 3939328
            1 6 11 16 21 26 31 36 41 46 51 56 61 66 71 76 81 86 91 96 101
            -1 7 25 50 76 108 190 447 1141 2741 6007 12088 22634 39922 66996 107821 167451 252211 369893 529966 743800
            2 13 47 129 307 666 1345 2569 4722 8498 15187 27209 49143 89767 166101 311215 588730 1118619 2121239 3989641 7404275
            -2 16 54 115 202 321 500 852 1723 3979 9499 21954 47965 98746 192351 356657 633228 1082218 1788484 2869093 4482420
            9 9 16 36 79 180 438 1076 2525 5535 11316 21712 39411 68194 113226 181392 281681 425621 627768 906252 1283383
            -5 1 21 69 164 336 652 1267 2502 4951 9623 18134 32979 57936 98684 163756 265997 424757 669121 1042563 1609510
            7 16 28 43 61 82 106 133 163 196 232 271 313 358 406 457 511 568 628 691 757
            11 9 7 5 3 1 -1 -3 -5 -7 -9 -11 -13 -15 -17 -19 -21 -23 -25 -27 -29
            12 23 46 111 260 540 1007 1756 3002 5257 9675 18672 36982 73423 143934 277182 525808 990279 1870244 3573361 6938576
            10 17 48 128 305 663 1335 2516 4476 7573 12266 19128 28859 42299 60441 84444 115646 155577 205972 268784 346197
            2 19 52 116 233 425 709 1095 1583 2150 2713 3049 2648 470 -5428 -18434 -44136 -91339 -173398 -309926 -528941
            -4 -9 -17 -26 -25 22 205 723 1990 4829 10803 22744 45553 87356 161113 286789 494208 826723 1345847 2137002 3316555
            15 26 53 120 261 517 950 1695 3077 5826 11429 22664 44367 84489 155506 276251 474243 788594 1273581 2002976 3075233
            29 43 57 71 85 99 113 127 141 155 169 183 197 211 225 239 253 267 281 295 309
            10 13 8 -3 -15 -9 84 453 1525 4154 9921 21622 44097 85690 160846 294650 530472 942235 1653042 2861771 4878453
            9 16 47 111 219 394 681 1161 1988 3491 6416 12440 25204 52344 109433 227490 466883 942166 1864729 3613125 6844481
            26 45 67 102 171 307 570 1090 2153 4340 8714 17021 31824 56420 94295 147747 215148 286119 333653 301936 88281
            17 35 64 102 146 205 338 727 1792 4354 9858 20682 40582 75383 134219 232202 396911 684641 1220040 2288434 4540598
            8 17 39 77 134 213 317 449 612 809 1043 1317 1634 1997 2409 2873 3392 3969 4607 5309 6078
            8 19 35 55 85 143 277 608 1408 3223 7065 14752 29631 58299 114769 230199 474424 1001019 2136783 4551173 9563745
            9 8 21 70 185 404 773 1346 2185 3360 4949 7038 9721 13100 17285 22394 28553 35896 44565 54710 66489
            23 51 103 190 334 587 1061 1973 3716 6985 13023 24126 44702 83494 158168 304496 594041 1166835 2289339 4453338 8538746
            -9 -5 16 62 155 345 739 1557 3239 6666 13649 28022 58002 121021 253079 525918 1077099 2160521 4228218 8058594 14951817
            21 39 68 102 141 202 330 609 1173 2217 4008 6896 11325 17844 27118 39939 57237 80091 109740 147594 195245
            1 9 39 106 229 439 798 1438 2641 4996 9692 19055 37556 73801 144663 284149 562669 1128767 2298205 4740064 9855499
            25 46 91 176 335 634 1188 2192 3984 7177 12943 23619 43946 83467 160955 312396 605538 1167687 2242414 4311733 8366012
            1 4 4 9 43 148 384 836 1660 3236 6557 14089 31515 71074 157733 340433 712639 1450356 2883306 5628789 10842031
            12 17 44 112 258 563 1191 2441 4812 9081 16394 28370 47218 75867 118109 178755 263804 380625 538152 747092 1020146
            -2 -7 -3 22 81 187 352 586 896 1285 1751 2286 2875 3495 4114 4690 5170 5489 5569 5318 4629
            9 8 12 37 119 341 873 2025 4313 8538 15878 27993 47143 76319 119387 181245 267993 387116 547680 760541 1038567
            7 19 45 93 179 339 650 1266 2488 4912 9735 19354 38509 76513 151821 301750 603281 1216629 2473213 5045951 10265339
            9 19 27 26 3 -66 -218 -494 -905 -1353 -1480 -396 3831 15201 41913 100707 225285 481687 994689 1990506 3862035
            27 39 64 125 250 472 849 1530 2904 5888 12450 26545 55797 114526 229134 447476 854792 1600561 2944730 5341858 9605945
            11 40 84 151 263 459 803 1406 2471 4370 7762 13761 24163 41741 70617 116720 188339 296780 457136 689179 1018383
            6 17 42 100 224 475 971 1937 3778 7173 13184 23370 39892 65591 104017 159383 236414 340057 475014 645056 852072
            13 23 35 50 80 166 410 1030 2468 5616 12274 26017 53725 108121 211767 403087 745119 1337845 2335109 3967308 6571230
            15 35 75 149 282 516 924 1642 2927 5242 9365 16538 28746 49389 84938 148717 268807 503317 968015 1883675 3653602
            9 30 76 163 305 522 872 1518 2841 5610 11220 22009 41665 75734 132240 222428 361641 570342 875292 1310895 1920721
            21 28 41 70 133 273 599 1376 3208 7393 16592 36055 75800 154381 305292 587808 1105471 2037998 3696899 6622680 11753751
            8 27 66 147 304 580 1033 1772 3057 5529 10707 22026 46939 101055 216098 454934 939486 1901747 3775336 7356561 14081706
            -1 -6 -4 19 85 229 504 986 1779 3020 4884 7589 11401 16639 23680 32964 44999 60366 79724 103815 133469
            19 30 54 104 187 308 489 821 1578 3431 7814 17528 37746 77733 153859 294907 551317 1010924 1825014 3250216 5713957
            21 41 70 124 239 473 916 1734 3302 6534 13604 29380 64072 137834 288368 582964 1136883 2140559 3898770 6885716 11820853
            -1 5 18 37 73 175 471 1236 3017 6883 14945 31442 64987 133174 272024 555469 1135812 2327901 4783249 9845571 20263562
            5 -2 -19 -36 -20 94 419 1147 2605 5348 10303 18980 33768 58336 98161 161207 258781 406594 626057 945844 1403756
            -2 0 5 15 37 104 319 935 2485 5981 13226 27363 53985 103556 196703 375354 725012 1417050 2785263 5458603 10582753
            19 26 35 63 138 307 666 1429 3061 6513 13615 27705 54596 104006 191594 341753 591303 994196 1627283 2597091 4047406
            6 11 32 88 200 401 761 1427 2678 4995 9146 16286 28072 46793 75515 118241 180086 267467 388308 552260 770936
            -9 -13 -6 28 116 314 743 1644 3462 6992 13657 26039 48849 90601 166348 301945 540425 951209 1643020 2781534 4612978
            11 7 -5 -20 -18 38 211 626 1569 3720 8656 19866 44678 97719 206824 422690 834047 1590701 2937505 5263144 9168590
            10 30 63 109 168 240 325 423 534 658 795 945 1108 1284 1473 1675 1890 2118 2359 2613 2880
            8 13 26 62 138 273 488 806 1252 1853 2638 3638 4886 6417 8268 10478 13088 16141 19682 23758 28418
            15 12 1 -23 -57 -69 35 456 1559 3942 8517 16603 30031 51261 83511 130898 198591 292976 421833 594525 822199
            3 10 34 81 168 336 659 1243 2213 3696 5823 8806 13236 20970 37448 77174 175631 413358 961632 2164559 4679824
            -4 -4 16 82 227 498 974 1801 3255 5852 10546 19105 34848 64097 119029 223293 423182 810080 1565696 3052536 5991817
            8 13 13 8 -2 -17 -37 -62 -92 -127 -167 -212 -262 -317 -377 -442 -512 -587 -667 -752 -842
            10 29 70 154 311 575 976 1538 2306 3442 5461 9745 19601 42341 93185 202283 426988 873111 1732174 3348456 6343141
            8 15 43 120 284 578 1044 1717 2627 3834 5556 8516 14749 29297 63507 141067 308506 652689 1328905 2604528 4924986
            1 11 34 80 172 357 716 1372 2496 4325 7240 12016 20485 37151 73009 154445 343531 782783 1789890 4049604 8986042
            5 7 15 28 45 65 87 110 133 155 175 192 205 213 215 210 197 175 143 100 45
            18 27 48 103 237 544 1208 2559 5144 9813 17820 30939 51595 83010 129364 195971 289470 418031 591576 822015 1123497
            21 43 83 155 286 534 1016 1946 3683 6789 12097 20789 34484 55336 86142 130460 192737 278447 394239 548095 749498
            15 32 60 94 124 135 107 15 -171 -486 -970 -1668 -2630 -3911 -5571 -7675 -10293 -13500 -17376 -22006 -27480
            6 15 39 91 184 331 545 839 1226 1719 2331 3075 3964 5011 6229 7631 9230 11039 13071 15339 17856
            17 23 43 89 181 371 795 1783 4071 9184 20113 42528 87032 173535 340054 660808 1283697 2507585 4939611 9809451 19583171
            3 16 36 69 126 235 461 930 1863 3650 7052 13747 27686 58160 126167 276687 600947 1274952 2624068 5229525 10103798
            9 21 33 56 124 318 817 2003 4666 10373 22086 45156 88925 169422 314203 571534 1028279 1844645 3320155 6014820 10963458
            13 17 24 44 96 209 427 834 1639 3398 7513 17266 39872 90457 199629 427664 890761 1809323 3596826 7024560 13529936
            9 7 1 0 26 129 422 1141 2742 6061 12584 24902 47461 87759 158191 278799 481247 814411 1352051 2203116 3525324
            -3 -1 4 14 27 46 107 344 1136 3423 9332 23313 54037 117335 240434 467640 867387 1540163 2626176 4310660 6823355
            17 38 67 97 122 145 188 304 591 1205 2361 4296 7144 10638 13506 12365 -163 -38488 -128737 -315725 -673018
            -1 -5 -6 7 65 237 649 1513 3189 6327 12190 23385 45502 90700 185258 384768 803303 1666951 3408070 6825103 13344531
            22 47 81 135 232 407 707 1191 1930 3007 4517 6567 9276 12775 17207 22727 29502 37711 47545 59207 72912
            14 28 67 154 326 639 1189 2174 4047 7863 16032 33896 72905 156742 332620 691238 1400644 2761630 5295409 9878342 17943552
            14 17 29 61 126 252 508 1043 2138 4271 8195 15029 26362 44370 71946 112843 171830 254861 369257 523901 729446
            1 5 18 40 71 111 160 218 285 361 446 540 643 755 876 1006 1145 1293 1450 1616 1791
            12 18 26 34 45 82 215 600 1530 3498 7272 13982 25219 43146 70621 111332 169944 252258 365382 517914 720137
            9 12 15 12 -9 -60 -136 -187 -79 456 1881 4926 10671 20640 36906 62207 100073 154964 232419 339216 483543
            -3 -4 6 41 129 329 760 1648 3390 6624 12277 21534 35628 55299 79725 104721 120083 106196 30528 -154473 -509109
            9 17 49 130 296 588 1056 1788 2988 5141 9315 17647 34016 64767 119016 207380 336732 496562 629578 575329 -28787
            19 25 36 62 113 199 330 516 767 1093 1504 2010 2621 3347 4198 5184 6315 7601 9052 10678 12489
            5 16 36 60 76 62 -7 -132 -233 -52 994 4020 10950 24874 50495 94676 167097 281032 454256 710092 1078608
            -3 -2 -2 -1 15 81 279 796 2044 4917 11353 25528 56261 121611 257333 532148 1075396 2128134 4140269 7960047 15209916
            8 19 36 71 151 322 662 1317 2574 4988 9602 18368 35033 67049 129564 253328 499492 985889 1931576 3729309 7059355
            15 21 41 97 230 520 1133 2404 4971 9986 19440 36649 66977 119004 206812 355370 614139 1090735 2029651 3985113 8178780
            8 18 25 40 88 208 453 890 1600 2678 4233 6388 9280 13060 17893 23958 31448 40570 51545 64608 80008
            12 35 82 172 331 591 994 1620 2680 4750 9275 19554 42544 92020 193961 395649 781200 1498749 2809472 5178044 9441173
            12 26 43 72 138 296 670 1546 3570 8136 18103 39080 81734 166067 329694 644430 1250015 2422394 4709724 9197418 18012729
            6 17 55 141 315 662 1354 2710 5276 9927 17993 31411 52905 86196 136244 209524 314338 461165 663051 936041 1299655
            25 37 56 89 143 225 342 501 709 973 1300 1697 2171 2729 3378 4125 4977 5941 7024 8233 9575
            16 32 66 133 271 566 1189 2447 4861 9300 17226 31159 55594 98875 177099 322226 598582 1135412 2188850 4255693 8275121
            26 36 53 92 185 394 822 1614 2938 4936 7637 10828 13885 15574 13842 5630 -13246 -48084 -105075 -190772 -311127
            20 39 84 183 385 781 1549 3042 5953 11617 22567 43594 83851 161122 310476 601561 1172588 2296261 4506756 8843399 17316791
            13 15 16 18 27 67 202 574 1480 3536 8020 17562 37481 78314 160584 323956 645379 1276101 2518344 4983770 9915659
            0 0 1 6 30 109 316 807 1946 4606 10819 25068 56728 124591 265290 549185 1110556 2204764 4314821 8345522 15967562
            3 7 11 15 19 23 27 31 35 39 43 47 51 55 59 63 67 71 75 79 83
            -1 -5 -3 19 92 272 648 1358 2641 4985 9475 18501 37054 74918 150158 294408 560579 1033735 1846025 3196711 5378496
            14 19 30 44 53 54 64 131 340 834 1917 4399 10517 26097 65285 160571 383867 891105 2017623 4483900 9840214
            3 -3 -6 -2 13 43 92 164 263 393 558 762 1009 1303 1648 2048 2507 3029 3618 4278 5013
            25 42 56 62 66 107 297 894 2426 5882 12979 26502 50697 91675 157758 259666 410407 624690 917634 1302494 1787068
            11 22 38 62 101 171 303 552 1031 2029 4344 10116 24775 61383 149880 355849 816755 1808556 3862422 7960118 15847105
            10 27 55 108 212 411 785 1488 2816 5329 10101 19303 37617 75573 157022 334955 723266 1557567 3306799 6870486 13915798
            12 17 36 80 163 304 521 827 1263 2033 3844 8615 20843 50186 116403 258973 556061 1162132 2382703 4822953 9682702
            20 32 48 76 130 225 379 627 1062 1941 3930 8611 19436 43388 93697 194060 384928 732550 1341604 2372398 4063790
            12 22 51 113 234 467 912 1741 3228 5784 9997 16677 26906 42093 64034 94977 137692 195546 272583 373609 504282
            20 44 86 149 235 363 605 1156 2468 5493 12105 25826 53101 105620 204722 390086 737495 1396067 2667074 5169749 10183056
            11 17 37 93 225 507 1073 2154 4126 7579 13461 23477 41213 75033 144836 296488 630449 1355149 2881449 5982541 12054453
            1 12 38 79 137 221 365 674 1429 3324 7996 19172 45033 102837 227534 487181 1009633 2027540 3952478 7494437 13850081
            8 25 44 70 131 302 738 1720 3729 7584 14715 27705 51367 94910 176342 331382 631106 1215695 2356378 4564340 8774263
            7 25 53 95 171 330 676 1432 3094 6779 14968 33019 72133 155017 326564 674018 1365421 2723713 5370291 10502143 20420427
            19 30 45 64 83 87 47 -69 -258 -402 -130 1394 5772 15775 35858 72793 136421 240518 403763 650788 1013281
            -3 8 41 116 273 587 1187 2286 4240 7665 13652 24131 42446 74214 128552 219767 369615 610246 987963 1567934 2440007
            5 0 -5 -10 -15 -20 -25 -30 -35 -40 -45 -50 -55 -60 -65 -70 -75 -80 -85 -90 -95
            8 2 6 45 151 365 752 1431 2630 4805 8933 17242 34942 74069 161488 354607 770672 1638944 3389972 6803015 13241957
            8 29 67 127 223 394 730 1414 2803 5618 11405 23581 49606 105139 221458 457966 922282 1801243 3407135 6244643 11105377
            23 44 81 149 276 521 1013 2033 4171 8598 17499 34717 66660 123523 220875 381657 638631 1037312 1639405 2526757 3805820
            15 32 75 164 336 666 1294 2453 4493 7896 13277 21366 32966 48882 69816 96223 128123 164864 204831 245096 281004
            14 15 12 1 -27 -73 -93 70 803 2934 8126 19605 43454 90806 181391 349036 649884 1174289 2063560 3532969 5902707
            18 34 69 138 274 543 1059 1999 3618 6264 10393 16584 25554 38173 55479 78693 109234 148734 199053 262294 340818
            -8 -18 -29 -34 -19 41 186 475 990 1840 3165 5140 7979 11939 17324 24489 33844 45858 61063 80058 103513
            6 28 61 105 160 226 303 391 490 600 721 853 996 1150 1315 1491 1678 1876 2085 2305 2536
            17 36 78 157 302 573 1087 2067 3946 7585 14697 28606 55509 106448 200236 367614 656943 1141754 1930488 3178755 5104424
            27 51 95 180 341 640 1196 2247 4277 8269 16183 31806 62179 119874 226472 417681 750631 1313991 2241671 3731000 6066409
            8 28 57 98 167 306 596 1167 2195 3876 6390 9929 14975 23192 39582 77107 166306 375912 859327 1962860 4478119
            22 39 80 155 268 424 658 1101 2098 4393 9402 19617 39236 75214 139100 250291 441726 769595 1329388 2281599 3891676
            25 52 95 163 282 506 928 1691 2999 5128 8437 13379 20512 30510 44174 62443 86405 117308 156571 205795 266774
            8 32 69 123 205 333 544 940 1811 3922 9126 21574 49944 111339 237905 487997 965242 1851716 3466587 6370309 11548631
            23 34 56 110 239 521 1096 2230 4450 8795 17244 33412 63675 119064 218707 396582 715357 1294896 2369732 4401050 8286675
            8 19 37 69 136 286 624 1383 3073 6772 14682 31193 64932 132723 267237 531715 1048138 2050769 3987267 7708517 14822964
            18 38 67 102 138 168 183 172 122 18 -157 -422 -798 -1308 -1977 -2832 -3902 -5218 -6813 -8722 -10982
            13 23 56 136 299 593 1078 1826 2921 4459 6548 9308 12871 17381 22994 29878 38213 48191 60016 73904 90083
            2 8 14 20 26 32 38 44 50 56 62 68 74 80 86 92 98 104 110 116 122
            3 16 37 81 178 385 815 1693 3467 7034 14187 28449 56534 110763 212865 399709 731643 1304260 2264569 3832721 6330626
            6 16 41 107 250 525 1028 1934 3558 6447 11516 20264 35172 60554 104556 184024 336294 646890 1311855 2771517 5984294
            4 2 -1 8 60 209 531 1120 2094 3644 6192 10770 19795 38515 77591 157668 317564 629174 1224801 2347036 4438402
            21 36 58 87 123 166 216 273 337 408 486 571 663 762 868 981 1101 1228 1362 1503 1651
            -1 4 30 97 242 537 1115 2214 4271 8145 15648 30763 62297 129346 271948 570792 1181963 2395554 4730662 9083861 16953704
            7 11 34 93 211 417 745 1248 2072 3693 7533 17391 42546 104180 248248 570709 1266338 2722472 5698241 11665570 23453174
            21 43 87 167 308 561 1032 1928 3623 6754 12385 22347 40002 71924 131382 245098 465593 892589 1708475 3234847 6019680
            18 45 97 196 373 668 1130 1817 2796 4143 5943 8290 11287 15046 19688 25343 32150 40257 49821 61008 73993
            1 13 36 77 158 324 658 1323 2668 5455 11287 23343 47555 94394 181467 337165 605643 1053457 1778230 2919769 4674108
            12 11 20 55 135 280 509 838 1278 1833 2498 3257 4081 4926 5731 6416 6880 6999 6624 5579 3659
            -2 0 9 24 53 125 302 691 1456 2830 5127 8754 14223 22163 33332 48629 69106 95980 130645 174684 229881
            8 9 8 5 0 -7 -16 -27 -40 -55 -72 -91 -112 -135 -160 -187 -216 -247 -280 -315 -352
            18 23 24 21 14 3 -12 -31 -54 -81 -112 -147 -186 -229 -276 -327 -382 -441 -504 -571 -642
            11 25 62 128 239 433 794 1516 3043 6324 13220 27093 53595 101658 184664 321747 539147 871499 1362898 2067534 3049639
            18 28 45 69 100 138 183 235 294 360 433 513 600 694 795 903 1018 1140 1269 1405 1548
            21 36 75 158 312 576 1023 1811 3288 6203 12121 24216 48739 97651 193203 375671 716055 1336374 2441287 4366202 7648866
            18 23 27 33 48 103 299 885 2373 5699 12449 25186 47939 86949 151811 257206 425484 690439 1102711 1737359 2704274
            8 27 75 172 339 609 1053 1821 3198 5675 10035 17454 29617 48849 78261 121911 184980 273963 396875 563472 785487
            12 27 63 136 284 596 1255 2595 5172 9849 17895 31098 51892 83498 130079 196909 290556 419079 592239 821724 1121388
            5 15 22 24 31 69 178 406 801 1396 2177 3048 3916 5326 10802 33608 113793 357560 1023014 2699829 6676501
            -3 13 57 157 363 755 1466 2736 5015 9135 16573 29829 52945 92193 156962 260876 423177 670409 1038441 1574869 2341839
            6 19 40 75 146 297 610 1241 2484 4866 9268 17056 30192 51278 83466 130144 194282 277293 377232 486121 586150
            8 15 23 32 42 53 65 78 92 107 123 140 158 177 197 218 240 263 287 312 338
            10 7 13 50 168 466 1116 2387 4666 8473 14467 23440 36296 54012 77578 107913 145754 191515 245113 305758 371704
            -1 10 28 46 62 91 179 419 969 2072 4078 7468 12880 21137 33277 50585 74627 107286 150800 207802 281362
            13 20 48 116 247 467 814 1378 2403 4491 8953 18344 37186 72820 136257 242907 413401 676032 1076270 1709310 2817625
            -3 -8 -6 9 37 67 72 4 -211 -678 -1538 -2973 -5211 -8531 -13268 -19818 -28643 -40276 -55326 -74483 -98523
            15 20 44 112 273 621 1330 2709 5283 9906 17912 31310 53029 87219 139614 217963 332535 496704 727620 1046972 1481849
            5 14 36 79 148 252 424 754 1445 2931 6154 13202 28699 62699 136573 294921 629713 1329116 2775196 5735649 11730538
            4 8 26 74 169 324 539 788 1002 1048 704 -370 -2665 -6860 -13863 -24856 -41344 -65208 -98762 -144814 -206731
            15 22 24 30 54 117 255 529 1035 1919 3413 5922 10208 17734 31248 55703 99623 177036 310102 532566 894162
            8 8 26 90 245 556 1120 2096 3763 6628 11648 20729 37856 71534 139732 279279 562730 1127176 2221398 4280252 8038319
            -2 13 43 106 243 532 1122 2305 4658 9325 18585 36980 73471 145364 285116 551607 1048062 1949541 3543799 6290366 10903923
            -1 -5 1 46 183 499 1125 2246 4111 7043 11449 17830 26791 39051 55453 76974 104735 140011 184241 239038 306199
            0 -4 -3 13 54 130 251 427 668 984 1385 1881 2482 3198 4039 5015 6136 7412 8853 10469 12270
            8 8 5 2 2 21 115 427 1279 3370 8211 19065 42931 94647 205221 438421 923123 1915127 3913509 7878244 15639079
            20 43 83 149 254 415 653 993 1464 2099 2935 4013 5378 7079 9169 11705 14748 18363 22619 27589 33350
            23 32 45 70 132 286 641 1408 2999 6228 12708 25632 51343 102577 205257 412677 834650 1696151 3452770 7013569 14163981
            6 14 45 126 303 647 1260 2281 3892 6324 9863 14856 21717 30933 43070 58779 78802 103978 135249 173666 220395
            7 11 30 72 145 257 416 630 907 1255 1682 2196 2805 3517 4340 5282 6351 7555 8902 10400 12057
            16 38 86 168 300 518 903 1636 3117 6208 12696 26133 53346 107240 212277 415620 810058 1580506 3095602 6081802 11942260
            9 27 52 84 123 169 222 282 349 423 504 592 687 789 898 1014 1137 1267 1404 1548 1699
            28 50 82 121 155 159 95 -81 -402 -860 -1360 -1655 -1259 665 5445 15071 32400 61398 107422 177545 280927
            4 4 9 28 84 242 656 1640 3768 8008 15895 29748 52936 90198 148022 235088 362780 545772 802693 1156876 1637196
            -1 -5 2 32 97 224 489 1070 2329 4971 10421 21749 45813 97850 210608 451375 952035 1959691 3918580 7598118 14287121
            17 21 33 56 87 114 114 55 -95 -349 -669 -918 -793 264 3180 9393 21025 41089 73733 124524 200775
            18 41 89 169 280 407 509 506 278 -297 -1201 -1869 -149 10140 44562 139197 372917 910795 2087293 4564350 9631559
            19 39 84 161 281 479 844 1552 2890 5254 9099 14814 22490 31544 40157 44479 37549 7873 -62402 -199785 -442281
            5 11 14 21 61 199 567 1436 3362 7442 15714 31743 61499 114861 208702 373983 672487 1235361 2348306 4631749 9406189
            5 25 69 156 311 558 916 1405 2070 3032 4576 7287 12246 21299 37413 65134 111163 185067 300143 474454 732057
            20 39 65 91 107 99 48 -71 -290 -649 -1197 -1993 -3107 -4621 -6630 -9243 -12584 -16793 -22027 -28461 -36289
            3 -4 -13 -18 -7 56 268 860 2340 5760 13184 28457 58388 114442 214951 387647 671913 1119436 1790793 2743736 4006355
            7 16 37 89 206 438 846 1499 2487 3965 6239 9896 15966 26085 42604 68560 107391 162238 234633 322323 415926
            11 33 63 116 217 405 761 1479 3008 6307 13274 27434 55000 106455 198842 358993 627977 1067101 1765857 2852272 4506187
            10 24 42 70 132 289 684 1642 3880 8917 19816 42437 87430 173248 330510 608091 1081358 1863006 3116974 5075936 8062864
            4 23 63 133 242 399 613 893 1248 1687 2219 2853 3598 4463 5457 6589 7868 9303 10903 12677 14634
            2 5 8 11 14 17 20 23 26 29 32 35 38 41 44 47 50 53 56 59 62
            4 6 15 38 91 225 572 1422 3345 7377 15301 30079 56530 102394 179955 308387 516882 848304 1362335 2135300 3250013
            23 45 74 112 168 269 484 964 2001 4109 8130 15368 27754 48045 80060 128956 201547 306669 455594 662496 944972
            3 20 46 77 107 128 130 101 27 -108 -322 -635 -1069 -1648 -2398 -3347 -4525 -5964 -7698 -9763 -12197
            9 13 27 56 105 179 283 422 601 825 1099 1428 1817 2271 2795 3394 4073 4837 5691 6640 7689
            6 13 33 74 138 231 383 688 1385 3011 6666 14438 30043 59741 113594 207136 363528 616273 1012567 1617362 2518216
            """;
    }
}
