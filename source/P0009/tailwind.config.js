/** @type {import('tailwindcss').Config} */

const content = require('./tailwind.contentpaths.all.json');

const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
    content: content,
    theme: {
        fontFamily: {
            'sans': ['"Inter var"', ...defaultTheme.fontFamily.sans]
        },
        extend: {
            typography: {
                DEFAULT: {
                    css: {
                        'code::before': {
                            content: '""'
                        },
                        'code::after': {
                            content: '""'
                        },
                        'code.ticked::before': {
                            content: '"`"'
                        },
                        'code.ticked::after': {
                            content: '"`"'
                        }
                    }
                }
            }
        },
    },
    plugins: [
        require('@tailwindcss/typography')
    ],
}
