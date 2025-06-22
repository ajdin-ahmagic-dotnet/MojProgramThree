# Initialize Oh My Posh with enhanced random theme changing
$themesPath = $env:POSH_THEMES_PATH
# $global:lastThemeChange removed as it was unused
$global:currentTheme = ""
# $global:themeChangeInterval = 30 # Change theme every 30 seconds by default
$global:happinessLevel = 0

# Array of happy messages for theme changes
$happyMessages = @(
    "🎉 New theme brings new joy!",
    "✨ Theme magic activated!",
    "🌈 Color happiness deployed!",
    "🎨 Artistic vibes incoming!",
    "💫 Theme surprise delivered!",
    "🎭 New visual adventure!",
    "🔮 Theme randomness engaged!",
    "🎪 Terminal carnival mode!",
    "🌟 Stellar theme activated!",
    "🎊 Celebration colors loaded!"
)

# Function to display centered welcome box with happiness meter and live clock
function Show-CenteredWelcomeBox {
    $windowWidth = $host.UI.RawUI.WindowSize.Width
    $happinessMeter = "😊" * ([math]::Min($global:happinessLevel, 10))
    $boxContent = "☢️☢️☢️❗ WELCOME TO HELLL 💡🚨📁💼💻❗💡Ajdin Ahmagic💡❗💻💼📁🚨💡  WELCOME TO HELL ❗☢️☢️☢️"
    $happinessLine = "Happiness Level: $happinessMeter ($global:happinessLevel)"
    
    # Get current time with colorful formatting
    $currentTime = Get-Date -Format "dddd, MMMM dd, yyyy - HH:mm:ss"
    $clockLine = "🕐 Live Clock: $currentTime"
    
    $boxWidth = 90  # Width of your box
    $leftPadding = [math]::Max(0, [math]::Floor(($windowWidth - $boxWidth) / 2))
    $padding = " " * $leftPadding

    Clear-Host          
    Write-Host "$padding╔══════════════════════════════════════════════════════════════════════════════════════════════╗"
    Write-Host "$padding║$boxContent ║"
    Write-Host "$padding║ $happinessLine$((' ' * ([math]::Max(0, 88 - $happinessLine.Length)))) ║"
    Write-Host "$padding║ $clockLine$((' ' * ([math]::Max(0, 88 - $clockLine.Length)))) ║"
    Write-Host "$padding╚══════════════════════════════════════════════════════════════════════════════════════════════╝"
}

# Function to change Oh My Posh theme with happiness boost
function Set-RandomOhMyPoshTheme {
    if (-not $themesPath -or -not (Test-Path $themesPath)) {
        Write-Host "⚠️ Oh My Posh themes not found. Install Oh My Posh first!" -ForegroundColor Yellow
        return
    }
    
    $themes = Get-ChildItem -Path $themesPath -Filter "*.omp.json"
    if ($themes.Count -eq 0) {
        Write-Host "⚠️ No themes found in $themesPath" -ForegroundColor Yellow
        return
    }
    
    $theme = $themes | Get-Random
    $selectedTheme = Join-Path $themesPath $theme.Name
    
    # Avoid setting the same theme twice in a row
    if ($global:currentTheme -ne $theme.BaseName) {
        oh-my-posh init pwsh --config $selectedTheme | Invoke-Expression
        $happyMessage = $happyMessages | Get-Random
        Write-Host "$happyMessage Theme: $($theme.BaseName)" -ForegroundColor Green
        $global:currentTheme = $theme.BaseName
        $global:happinessLevel++
    }
}

# Function to manually trigger random theme change
function Get-RandomTheme {
    Set-RandomOhMyPoshTheme
    Write-Host "🎲 Manual theme randomization activated!" -ForegroundColor Cyan
}

# Function to set theme change interval
function Set-ThemeInterval {
    param([int]$seconds = 30)
    $global:themeChangeInterval = $seconds
    Write-Host "⏰ Theme change interval set to $seconds seconds" -ForegroundColor Magenta
}

# Function to boost happiness manually
function Add-Happiness {
    param([int]$amount = 1)
    $global:happinessLevel += $amount
    $happyEmoji = @("😊", "😄", "😁", "🥳", "🎉", "🌟", "✨", "🎊") | Get-Random
    Write-Host "$happyEmoji Happiness boosted! Current level: $global:happinessLevel" -ForegroundColor Yellow
}

# Function to set initial random theme on terminal start
# Create dynamic prompt function with smart theme changing
function prompt {
    # Display centered welcome box on every new line
    Show-CenteredWelcomeBox

    # Check if theme change interval has passed since last theme change
    # Theme auto-change interval logic removed as lastThemeChange is unused
    # Return a basic prompt if Oh My Posh fails
    "$PWD> "
}

# Initialize with first random theme
Set-RandomOhMyPoshTheme

# Set console properties
$host.UI.RawUI.WindowTitle = "Ajdin's Happy PowerShell Terminal 🎉"

# Display welcome message with available commands
Write-Host "`n🎨 Random Theme Happiness System Loaded! 🎨" -ForegroundColor Cyan
Write-Host "Available commands:" -ForegroundColor White
Write-Host "  • Get-RandomTheme        - Manually change theme" -ForegroundColor Green
Write-Host "  • Set-ThemeInterval [n]  - Set auto-change interval (seconds)" -ForegroundColor Green  
Write-Host "  • Add-Happiness [n]      - Boost your happiness level" -ForegroundColor Green
Write-Host "Current interval: $global:themeChangeInterval seconds`n" -ForegroundColor Yellow