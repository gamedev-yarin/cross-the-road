# cross-the-road
<div dir='rtl' lang='he'>
בחרתי במשחק הראשון (jumper frog).
 
 במטלה השתמשתי בסקריפטים מהמטלות הקודמות עם מספר שינויים קלים (לפי הצורך) וכתבתי סקריפט חדש לפי הצורך ([VehicleHit](https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/collisions/VehicleHit.cs))
 
 המשחק בנוי כך שכאשר השחקן נפגע מרכב או כשהוא נכנס למים הוא חוזר להתחלה ([VehicleHit](https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/collisions/VehicleHit.cs)) חלק זה מומש בעזרת קוליידרים שמזהים מגע של השחקן עם רכב ומגע של השחקן עם שטח המוגד כמים.
בנוסף לזה ישנו קוליידר נוסף המזהה את השלמת השלב ושולח את השחקן למסך הניצחון[GotoNextLevel](https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/level/GotoNextLevel.cs).

על מנהת להגביל את השחקן שלא יצא מגבולות המפה מחות למסך בכל צד ישנו "קיר" שהשחקן לא יכול לעבור אותו.

הרכבים נוצרים בעזרת מייצר (spaner [TimedSpawnerRandom](https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/spawners/TimedSpawnerRandom.cs)) וכדי למנוע מהעולם להתמלא ברכבים שנוסעים על המפה מחוץ למסך ישנם קירות הנועדו להרוס את המכוניות. [WallDestroyer](https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/collisions/WallDestroyer.cs)
</div>
