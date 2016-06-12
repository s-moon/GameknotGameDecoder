# Gameknot Game Decoder

This tool will allow you to take a [Gameknot](http://www.gameknot.com) interactive script (see below) and convert it into [PGN - Portable Game Notation](https://en.wikipedia.org/wiki/Portable_Game_Notation) format, quickly and easily. Why might you need this? Perhaps like me, you converted some PGN into this format to use GameKnot's interactive game code and then promptly lost the original PGN! The problem is (as I have found when contacting GameKnot), you can't reverse the process and sadly their script doesn't play nicely on all implementations of WordPress.

#### Input
JavaScript game code

```
<!-- iChess v1.2, (c) 2007-2009 GameKnot.com -->
<script type="text/javascript" src="http://e.ichess.com/ichess.js"></script>
<div id="ichess386491">Play <a href="http://gameknot.com/">chess</a> online</div>
<script type="text/javascript">/*
*/if ((typeof ichess_create)!='undefined')/*
*/{o=new ichess_create(11,'ichess386491',3);if(o){/*
*/o.im('e2e4e7e5g1f3b8c6a2a3d7d6d2d3c8g4f1e2g4f3e2f3h7h6c1e3'+/*
*/'f8e7e1g1g8f6b1c3a7a6c3e2e8g8e2g3d6d5g3h5d5d4h5f6e7f6e3d2f6g5'+/*
*/'g2g3g5d2d1d2d8f6f3g2b7b5f2f4f6d6f4f5f7f6b2b4a6a5c2c4b5c4b4b5'+/*
*/'c4c3d2a2g8h7b5c6d6c6a2c2a8b8a1b1b8b1f1b1a5a4g2f3c6d6c2a4c7c5'+/*
*/'f3d1f8b8b1b8d6b8a4b3b8c7b3c4c7a7d1b3h6h5h2h4h7h6c4g8a7a3g8h8');/*
*/o.il(0,0,1);/*
*/o.ip([0], ['-']);/*
*/o.ih(1,'Fuller%20League%2C%20%3F','Grist%2C%20Ken%20%2889%'+/*
*/'29%20vs.%20Oluwole%2C%20Isaac%20%2885%29');/*
*/o.go(0,0);}}/*
*/</script>
```

#### Output
Somethiung akin to:
```
[Event "F/S Return Match"]
[Site "Belgrade, Serbia Yugoslavia|JUG"]
[Date "1992.11.04"]
[Round "29"]
[White "Fischer, Robert J."]
[Black "Spassky, Boris V."]
[Result "1/2-1/2"]
 
1. e4 e5 2. Nf3 Nc6 3. Bb5 a6 {This opening is called the Ruy Lopez.}
4. Ba4 Nf6 5. O-O Be7 6. Re1 b5 7. Bb3 d6 8. c3 O-O 9. h3 Nb8  10. d4 Nbd7
11. c4 c6 12. cxb5 axb5 13. Nc3 Bb7 14. Bg5 b4 15. Nb1 h6 16. Bh4 c5 17. dxe5
Nxe4 18. Bxe7 Qxe7 19. exd6 Qf6 20. Nbd2 Nxd6 21. Nc4 Nxc4 22. Bxc4 Nb6
23. Ne5 Rae8 24. Bxf7+ Rxf7 25. Nxf7 Rxe1+ 26. Qxe1 Kxf7 27. Qe3 Qg5 28. Qxg5
hxg5 29. b3 Ke6 30. a3 Kd6 31. axb4 cxb4 32. Ra5 Nd5 33. f3 Bc8 34. Kf2 Bf5
35. Ra7 g6 36. Ra6+ Kc5 37. Ke1 Nf4 38. g3 Nxh3 39. Kd2 Kb5 40. Rd6 Kc5 41. Ra6
Nf2 42. g4 Bd3 43. Re6 1/2-1/2
```

#### Technologies Used
 * C# / .NET
 * NUnit
