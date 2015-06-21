

( cos 0-359 degrees
could be more space optimized )
header sintab
7fff , 823b , 8477 , 86b2 ,
88ed , 8b27 , 8d60 , 8f98 ,
91cf , 9405 , 9639 , 986b ,
9a9c , 9cca , 9ef6 , a120 ,
a347 , a56b , a78d , a9ab ,
abc6 , adde , aff2 , b202 ,
b40f , b617 , b81b , ba1b ,
bc16 , be0d , bfff , c1ec ,
c3d3 , c5b5 , c792 , c96a ,
cb3b , cd07 , cecd , d08c ,
d246 , d3f8 , d5a5 , d74a ,
d8e9 , da81 , dc12 , dd9c ,
df1e , e099 , e20c , e378 ,
e4dc , e638 , e78c , e8d9 ,
ea1c , eb58 , ec8b , edb6 ,
eed8 , eff2 , f103 , f20b ,
f30a , f400 , f4ee , f5d2 ,
f6ac , f77e , f846 , f905 ,
f9bb , fa67 , fb09 , fba2 ,
fc31 , fcb7 , fd32 , fda4 ,
fe0d , fe6b , fec0 , ff0a ,
ff4b , ff82 , ffaf , ffd2 ,
ffeb , fffa , ffff , fffa ,
ffeb , ffd2 , ffaf , ff82 ,
ff4b , ff0a , fec0 , fe6b ,
fe0d , fda4 , fd32 , fcb7 ,
fc31 , fba2 , fb09 , fa67 ,
f9bb , f905 , f846 , f77e ,
f6ac , f5d2 , f4ee , f400 ,
f30a , f20b , f103 , eff2 ,
eed8 , edb6 , ec8b , eb58 ,
ea1c , e8d9 , e78c , e638 ,
e4dc , e378 , e20c , e099 ,
df1e , dd9c , dc12 , da81 ,
d8e9 , d74a , d5a5 , d3f8 ,
d246 , d08c , cecd , cd07 ,
cb3b , c96a , c792 , c5b5 ,
c3d3 , c1ec , bfff , be0d ,
bc16 , ba1b , b81b , b617 ,
b40f , b202 , aff2 , adde ,
abc6 , a9ab , a78d , a56b ,
a347 , a120 , 9ef6 , 9cca ,
9a9c , 986b , 9639 , 9405 ,
91cf , 8f98 , 8d60 , 8b27 ,
88ed , 86b2 , 8477 , 823b ,
7fff , 7dc3 , 7b87 , 794c ,
7711 , 74d7 , 729e , 7066 ,
6e2f , 6bf9 , 69c5 , 6793 ,
6562 , 6334 , 6108 , 5ede ,
5cb7 , 5a93 , 5871 , 5653 ,
5438 , 5220 , 500c , 4dfc ,
4bef , 49e7 , 47e3 , 45e3 ,
43e8 , 41f1 , 3fff , 3e12 ,
3c2b , 3a49 , 386c , 3694 ,
34c3 , 32f7 , 3131 , 2f72 ,
2db8 , 2c06 , 2a59 , 28b4 ,
2715 , 257d , 23ec , 2262 ,
20e0 , 1f65 , 1df2 , 1c86 ,
1b22 , 19c6 , 1872 , 1725 ,
15e2 , 14a6 , 1373 , 1248 ,
1126 , 100c , efb , df3 ,
cf4 , bfe , b10 , a2c ,
952 , 880 , 7b8 , 6f9 ,
643 , 597 , 4f5 , 45c ,
3cd , 347 , 2cc , 25a ,
1f1 , 193 , 13e , f4 ,
b3 , 7c , 4f , 2c ,
13 , 4 , 0 , 4 ,
13 , 2c , 4f , 7c ,
b3 , f4 , 13e , 193 ,
1f1 , 25a , 2cc , 347 ,
3cd , 45c , 4f5 , 597 ,
643 , 6f9 , 7b8 , 880 ,
952 , a2c , b10 , bfe ,
cf4 , df3 , efb , 100c ,
1126 , 1248 , 1373 , 14a6 ,
15e2 , 1725 , 1872 , 19c6 ,
1b22 , 1c86 , 1df2 , 1f65 ,
20e0 , 2262 , 23ec , 257d ,
2715 , 28b4 , 2a59 , 2c06 ,
2db8 , 2f72 , 3131 , 32f7 ,
34c3 , 3694 , 386c , 3a49 ,
3c2b , 3e12 , 3fff , 41f1 ,
43e8 , 45e3 , 47e3 , 49e7 ,
4bef , 4dfc , 500c , 5220 ,
5438 , 5653 , 5871 , 5a93 ,
5cb7 , 5ede , 6108 , 6334 ,
6562 , 6793 , 69c5 , 6bf9 ,
6e2f , 7066 , 729e , 74d7 ,
7711 , 794c , 7b87 , 7dc3 ,

: sin 168 mod 2* ['] sintab + @ ;
: cos 5a + sin ;

# a = amplitude
# r = degree [0..ff]
# todo: lerp?
: *cos ( a r -- b )
cos over 2* 1+ d* drop swap - ;
: *sin ( a r -- b )
sin over 2* 1+ d* drop swap - ;

hide sintab
