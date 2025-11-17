
function load()
    print("Hello from Welle!")

    player = {
        texture = welle.graphics.loadTexture("image.png")
        x = 100,
        y = 100,
        speed = 5
    }

    print(player.texture.path)
end

function update(dt)
    if welle.input.keyboard.isKeyDown("a") then
       player.x = player.x - player.speed
    end
    if welle.input.keyboard.isKeyDown("d") then
       player.x = player.x + player.speed
    end
    if welle.input.keyboard.isKeyDown("w") then
       player.y = player.y - player.speed
    end
    if welle.input.keyboard.isKeyDown("s") then
       player.y = player.y + player.speed
    end
end

function draw()
    welle.graphics.clear(0.5, 0.5, 0.5, 1)

    welle.graphics.beginDraw()
    welle.graphics.draw(player.texture, player.x, player.y)
    welle.graphics.endDraw()
end