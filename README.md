PongGame
========

Pong Game

Класата Palka ги содржи следните:
1. Атрибути:
*PictureBox Pbox - слика за палката
*Size Golemina - големина на палката
*bool AI - проверка дали е бот за соодветно активирање на методите 
2. Методи:
*void playerMovement(Point m) - движење на играчот со маус
*void aiMovement(Point m, Topka t, int predY) - движење на ботот
*void player2Movement(KeyEventArgs e) - движење при избор на "TwoPlayer" мод од менито

Класата Topka ги содржи следните атрибути:
 int SpeedX - брзина на топката по X-оската
 int SpeedY - брзина на топката по Y-оската
 PictureBox Ball - слика за топката
 
Класата Igra ги содржи сите потребни методи за одвивање на играта при различни избори од Game Menu.
Во оваа класа се наоѓа Timer како и Timer Tick евентот. 

Во класата Igra и Palka се чуваат приватни променливи од Form1 за добивање на потребните координати.

Формата Game Menu е направена за избор на различни модови на играта.
