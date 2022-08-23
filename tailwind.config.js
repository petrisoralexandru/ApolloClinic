/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./ApolloClinic/**/*.cshtml"],
  theme: {
    extend: {
      colors: {
        'blue': {
          DEFAULT: '#1363DF',
          50: '#B1CDF8',
          100: '#9EC1F7',
          200: '#79A9F4',
          300: '#5391F0',
          400: '#2E79ED',
          500: '#1363DF',
          600: '#0F4CAB',
          700: '#0A3578',
          800: '#061E44',
          900: '#010710'
        },
        'main-text': '#2e333c',
        'hover-text': '#c0c1c4',
      },
      fontFamily: {
        'tiempos': ['Tiempos Headline'],
        'graphik': ['Graphik']
      }
    },
  },
  plugins: [],
}
