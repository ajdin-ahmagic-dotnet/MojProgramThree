function updateTheme(newTheme) {

    const _lastThemeChange = Date.now(); // ✅ Indicates intentionally unused
    
    document.body.className = newTheme;
    localStorage.setItem('theme', newTheme);

}