export function generateTOC(bodyId, tocId) {
    // hrefBase 生成toc链接基础 根地址+#
    let hrefBase = window.location.href.replace(window.location.hash, '') + '#';
    // 获取 markdown 的文章内容与目录节点
    let markdown = document.getElementById(bodyId);
    let toc = document.getElementById(tocId);
    // 遍历 markdown 文章html 提取目录 并生成目录
    for (let i = 0; i < markdown.childElementCount; i++) {
        const element = markdown.children[i];
        if (element.tagName[0] === 'H') {
            toc.innerHTML += `<li  style=\'padding-left:${(element.tagName[1] - 1) * 0.5}rem;\'>
                                  <a href=\'${hrefBase}${element.getAttribute('id')}\'  target=\'_top\' >${element.innerHTML}</a>
                              </li>`;
        }
    }
}

const light = 'css/github-markdown-css/github-markdown-light.css';
const dark = 'css/github-markdown-css/github-markdown-dark.css';
export function switchTheme(themeId) {
    let style = document.getElementById(themeId);
    let theme = localStorage.getItem(themeId);
    if (theme == "light") {
        style.href = dark;
        localStorage.setItem(themeId, "dark");
    }
    else if (theme == "dark") {
        style.href = light;
        localStorage.setItem(themeId, "light");
    }
}

export function getMarkdownTheme(themeId) {
    let style = document.getElementById(themeId);
    let theme = localStorage.getItem(themeId);
    console.log('js ' + theme);
    if (theme == "light") {
        style.href = light;
        return "light";
    }
    else if (theme == "dark") {
        style.href = dark;
        return "dark";
    }
    else {
        localStorage.setItem(themeId, "light");
        style.href = dark;
        return "light";
    }
}
