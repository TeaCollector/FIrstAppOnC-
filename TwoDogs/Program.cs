int distance = 10000, 
firstSpeed = 1, 
secondSpeed = 2, 
dogSpeed = 5,
friend = 2,
time = 0,
count = 0;

while (distance > 10) {

    if (friend == 1) {
        time = distance  / (firstSpeed + dogSpeed);
        friend = 2;
    }
    else {
        time = distance / (secondSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstSpeed + secondSpeed) * time;
    count++;
}
Console.WriteLine("Собака пробежит: " + count); 
