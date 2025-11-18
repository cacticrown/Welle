function load()
    texture = welle.graphics.loadTexture("image.png")

    textureX = texture.width
    textureY = texture.height

    windowX = welle.window.width
    windowY = welle.window.height

    position = welle.math.vector2.init(math.random(windowX - textureX), math.random(windowY - textureY))

    speed = 250

    dirX = 1
    dirY = 1
end

function update(dt)
    windowX = welle.window.width
    windowY = welle.window.height

    position.x = position.x + dirX * speed * dt
    position.y = position.y + dirY * speed * dt

    if position.x <= 0 then
        position.x = 0
        dirX = 1
    elseif position.x + textureX >= windowX then
        position.x = windowX - textureX
        dirX = -1
    end

    if position.y <= 0 then
        position.y = 0
        dirY = 1
    elseif position.y + textureY >= windowY then
        position.y = windowY - textureY
        dirY = -1
    end
end

function draw()
    welle.graphics.clear(welle.graphics.color.init(50, 50, 50, 255))

    welle.graphics.beginDraw()
    welle.graphics.draw(texture, position)
    welle.graphics.endDraw()
end