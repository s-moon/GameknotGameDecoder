# Gameknot Game Decoder

This tool will allow you to take a Gameknot interactive script (see below) and convert it into [PGN](https://en.wikipedia.org/wiki/Portable_Game_Notation) format, quickly and easily.

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
PGN text
