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
    //console.log('js ' + theme);
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
        style.href = light;
        return "light";
    }
}

export function initToHtmlByEditor(element) {
    console.log('initToHtmlByEditor')
    var testEditor = editormd(element, {
        width: "100%",
        height: "max",
        path: 'editor/lib/',
        sequenceDiagram: true
    });
}

export function markdownToHTMLByEditor(element, markdownc, urltoc, tocc) {

    var testEditormdView = editormd.markdownToHTML(element, {
        markdown: markdownc,//+ "\r\n" + $("#append-test").text(),
        //htmlDecode      : true,       // 开启 HTML 标签解析，为了安全性，默认不开启
        htmlDecode: "style,script,iframe",  // you can filter tags decode
        toc: true,
        tocm: true,    // Using [TOCM]
        tocContainer: tocc, // 自定义 ToC 容器层  容器与下拉不共存？？？？？？？？
        //gfm             : false,
        tocDropdown: true,
        // markdownSourceCode : true, // 是否保留 Markdown 源码，即是否删除保存源码的 Textarea 标签
        urltoc: urltoc,
        emoji: false,
        taskList: true,
        tex: true,  // 默认不解析
    });

}

import OrgChart from './orgchart.js';

export function InitTree(data = undefined) {

    //console.log(data)
    //console.log(JSON.parse(data))
    let datascource = {
        'name': 'Lao Lao',
        'title': 'general manager',
        'children': [
            {
                'name': 'Bo Miao', 'title': 'department manager', 'className': 'middle-level',
                'children': [
                    { 'name': 'Li Jing', 'title': 'senior engineer', 'className': 'product-dept' },
                    {
                        'name': 'Li Xin', 'title': 'senior engineer', 'className': 'product-dept',
                        'children': [
                            { 'name': 'To To', 'title': 'engineer', 'className': 'pipeline1' },
                            { 'name': 'Fei Fei', 'title': 'engineer', 'className': 'pipeline1' },
                            { 'name': 'Xuan Xuan', 'title': 'engineer', 'className': 'pipeline1' }
                        ]
                    }
                ]
            },
            {
                'name': 'Su Miao', 'title': 'department manager', 'className': 'middle-level',
                'children': [
                    { 'name': 'Pang Pang', 'title': 'senior engineer', 'className': 'rd-dept' },
                    {
                        'name': 'Hei Hei', 'title': 'senior engineer', 'className': 'rd-dept',
                        'children': [
                            { 'name': 'Xiang Xiang', 'title': 'UE engineer', 'className': 'frontend1' },
                            { 'name': 'Dan Dan', 'title': 'engineer', 'className': 'frontend1' },
                            { 'name': 'Zai Zai', 'title': 'engineer', 'className': 'frontend1' }
                        ]
                    }
                ]
            }
        ]
    },
        orgchart = new OrgChart({
            'chartContainer': '#chart-container',
            'data': data ? JSON.parse(data) : datascource,
            'nodeContent': 'title',
            'toggleSiblingsResp':true
        });

}