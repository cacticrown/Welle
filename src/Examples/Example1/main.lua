function load()
    texture = welle.graphics.loadTexture("image.png")

    textureX = texture.width
    textureY = texture.height

    windowX = welle.window.width
    windowY = welle.window.height

    x = math.random(windowX - textureX)
    y = math.random(windowY - textureY)

    speed = 250

    dirX = 1
    dirY = 1
end

function update(dt)
    windowX = welle.window.width
    windowY = welle.window.height

    x = x + dirX * speed * dt
    y = y + dirY * speed * dt

    if x <= 0 then
        x = 0
        dirX = 1
    elseif x + textureX >= windowX then
        x = windowX - textureX
        dirX = -1
    end

    if y <= 0 then
        y = 0
        dirY = 1
    elseif y + textureY >= windowY then
        y = windowY - textureY
        dirY = -1
    end
end

function draw()
    welle.graphics.clear(welle.graphics.color.init(50, 50, 50, 255))

    welle.graphics.beginDraw()
    welle.graphics.draw(texture, x, y)
    welle.graphics.endDraw()
end